using System;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TeamLogbook
{
    public partial class Home : Form
    {
		private Form form; // окно для различных форм

		DBController db_controller = new DBController();

		public Home()
        {
            InitializeComponent();
        }

		private void PanelForm(Form fm)
		/*
			Функция для передачи формы на панель
		*/
		{
			if (form != null)
				form.Close();

			form = fm;
			fm.TopLevel = false;
			fm.FormBorderStyle = FormBorderStyle.None;
			fm.Dock = DockStyle.Fill;
			this.form_panel.Controls.Add(fm);
			this.form_panel.Tag = fm;
			fm.BringToFront();
			fm.Show();
		}

		private void load_filters()
		{
			string[] groups = db_controller.get_values_from_db("Group", "Marks");
			string[] students = db_controller.get_values_from_db("Student", "Marks");
			string[] lessons = db_controller.get_values_from_db("Lesson", "Marks");

			for (int i = 0; i < groups.Length; i++)
			{
				group_fl.Items.Add(groups[i]);
			}

			for (int i = 0; i < students.Length; i++)
			{
				student_fl.Items.Add(students[i]);
			}

			for (int i = 0; i < lessons.Length; i++)
			{
				subject_fl.Items.Add(lessons[i]);
			}
		}

		private void Home_Load(object sender, EventArgs e)
		{
			load_filters();
			PanelForm(new Main());
			btn_save.Enabled = false;
			btn_save_as.Enabled = false;
			lb_save.Hide();

			int interval = Int32.Parse(db_controller.get_value_from_db("Range"));
			if (interval > 0)
			{
				System.Timers.Timer timer = new System.Timers.Timer();

				timer.Interval = interval * 60 * 1000; // Установка интервала в миллисекундах
				timer.Elapsed += autosave;
				timer.Start(); 
			}
		}


		private void filters_panel(bool is_active)
		{
			if (is_active)
			{
				group_fl.Enabled = true;
				subject_fl.Enabled = true;
				student_fl.Enabled = true;
				btn_apply_fl.Enabled =true;
			}
			else
			{
				group_fl.Enabled = false;
				subject_fl.Enabled = false;
				student_fl.Enabled = false;
				btn_apply_fl.Enabled = false;
			}
		}

		private void main_panel(bool is_active)
		{
			if (is_active){
				btn_load.Enabled = true;
				btn_save.Enabled = true;
				btn_save_as.Enabled = true;
				btn_settings.Enabled = true;
			}
			else{ 
				btn_load.Enabled = false;
				btn_save.Enabled = false;
				btn_save_as.Enabled = false;
				btn_settings.Enabled = false;
			}
		}

		// Кнопки меню
		private void btn_main_Click(object sender, EventArgs e)
		{
			PanelForm(new Main());
			filters_panel(false);
			main_panel(true);
			btn_save.Enabled = false;
			btn_save_as.Enabled = false;
		}

		private void btn_log_Click(object sender, EventArgs e)
		{
			PanelForm(new Log(false));
			filters_panel(true);
			main_panel(true);
		}

		private void btn_progress_Click(object sender, EventArgs e)
		{
			PanelForm(new Progress());
			filters_panel(true);
			main_panel(false);
		}

		private void btn_pass_Click(object sender, EventArgs e)
		{
			PanelForm(new Miss());
			filters_panel(true);
			main_panel(false);
		}

		private void btn_report_Click(object sender, EventArgs e)
		{
			PanelForm(new Report());
			filters_panel(false);
			main_panel(false);
		}

		// Функциональные кнопки
		private void btn_settings_Click(object sender, EventArgs e)
		{
			PanelForm(new Options());
			filters_panel(false);
			main_panel(false);
		}

		private void btn_load_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = openFileDialog1.FileName; // получаем выбранный файл
			string extension = Path.GetExtension(filename);

			if (extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
			{
				FileManager fileManager = new FileManager(filename);

				db_controller.update_config_value(filename, "CurrentFile");

				MessageBox.Show("Программа начала загружать файл", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
				db_controller.save();


				if (form_panel.Controls[0].Text == "Log")
				{
					DataGridView dgv = (DataGridView)form_panel.Controls[0].Controls["dataGridView"];
					dgv.Show();
					fileManager.read_file(dgv);
				}
				else if (form_panel.Controls[0].Text == "Main")
				{
					Label cur_file = (Label)form_panel.Controls[0].Controls["lb_curr_file"];
					Label last_mod = (Label)form_panel.Controls[0].Controls["lb_last_edit"];
					Label info = (Label)form_panel.Controls[0].Controls["info_lb"];
					FileManager file_manager = new FileManager(filename);
					string[] fileinfo = file_manager.getFileInfo();
					cur_file.Text = "Текущий файл: " + fileinfo[0];
					last_mod.Text = "Последнее изменение: " + fileinfo[1];
					last_mod.Show();
					cur_file.Show();
					info.Hide();

					MessageBox.Show("Файл загружен и отображён на вкладке журнал", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
				MessageBox.Show("Файл имеет неверный формат", "Ошибка загурзки файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// сохранения
		private async void btn_save_Click(object sender, EventArgs e)
		{
			lb_save.Show();
			await Task.Run(() => db_controller.save());// Вызываем сохранение в фоновом потоке

			this.Invoke((MethodInvoker)delegate
			{
				// Код для обновления UI
				lb_save.Text = "Сохранено";
				lb_save.Hide();
				lb_save.Text = "Сохранение...";
			});
			save(db_controller.get_value_from_db("CurrentFile"));
		}

		private async void btn_save_as_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			lb_save.Show();
			await Task.Run(() => db_controller.save());// Вызываем сохранение в фоновом потоке

			this.Invoke((MethodInvoker)delegate
			{
				// Код для обновления UI
				lb_save.Text = "Сохранено";
				lb_save.Hide();
				lb_save.Text = "Сохранение...";
			});

			save(saveFileDialog1.FileName.ToString());
		}

		private async void autosave(object sender, ElapsedEventArgs e)
		{
			lb_save.Show();
			await Task.Run(() => db_controller.save());// Вызываем сохранение в фоновом потоке

			this.Invoke((MethodInvoker)delegate
			{
				// Код для обновления UI
				lb_save.Text = "Сохранено";
				lb_save.Hide();
				lb_save.Text = "Сохранение...";
			});
			save(db_controller.get_value_from_db("SavePath") + "\\teamlogbook-autosave.xlsx");
		}

		private void save(string filename)
		{
			FileManager fileManager = new FileManager(filename);
			DataGridView dg = (DataGridView)form_panel.Controls[0].Controls["dataGridView"];

			fileManager.ExportToExcel(dg);
		}

		// применение фильтров
		private void btn_apply_fl_Click(object sender, EventArgs e)
		{
			string student = student_fl.Text;
			string group = group_fl.Text;
			string subject = subject_fl.Text;

			DataGridView dgv = (DataGridView)form_panel.Controls[0].Controls["dataGridView"];

			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dgv.DataSource; // Используйте исходный источник данных
			dgv.DataSource = bindingSource;

				List<string> conditions = new List<string>();

				if (student != "Учащийся")
					conditions.Add("Student=\'" + student + "\'");

				if (group != "Группа")
					conditions.Add("Group=\'" + group + "\'");

				if (subject != "Предмет")
					conditions.Add("Lesson=\'" + subject + "\'");

				string condition = string.Join(" AND ", conditions);

				if (!string.IsNullOrEmpty(condition))
					bindingSource.Filter = condition;
				else
					bindingSource.Filter = "";
		}

	}
}
