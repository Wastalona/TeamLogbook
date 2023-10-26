using NPOI.SS.UserModel;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;
using System.Threading;
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
			string[] students = db_controller.get_values_from_db("Student", "Marks");
			for (int i = 0; i < students.Length; i++)
			{
				student_fl.Items.Add(students[i]);
			}
			string[] groups = db_controller.get_values_from_db("Group", "Marks");
			for (int i = 0; i < groups.Length; i++)
			{
				group_fl.Items.Add(groups[i]);
			}
			string[] lessons = db_controller.get_values_from_db("Lesson", "Marks");
			for (int i = 0; i < lessons.Length; i++)
			{
				subject_fl.Items.Add(lessons[i]);
			}
		}

		private void Home_Load(object sender, EventArgs e)
		{
			load_filters();

			System.Timers.Timer timer = new System.Timers.Timer(); // Используйте полное имя класса

			timer.Interval = Int32.Parse(db_controller.get_value_from_db("Range")) * 60 * 1000; // Установка интервала в миллисекундах
			timer.Elapsed += autosave;

			PanelForm(new Main());
			btn_save.Enabled = false;
			btn_save_as.Enabled = false;
			timer.Start(); // Обратите внимание, что "Start" с заглавной буквы
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


		private void btn_clear_all_Click(object sender, EventArgs e)
		{
			MessageBox.Show(form_panel.Controls[0].Text);
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			db_controller.save();
			save(db_controller.get_value_from_db("CurrentFile"), true);
		}

		private void btn_save_as_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			db_controller.save();
			save(saveFileDialog1.FileName.ToString(), true);
		}

		private void autosave(object sender, ElapsedEventArgs e)
		{
			db_controller.save();
			save(db_controller.get_value_from_db("SavePath") + "\\teamlogbook-autosave.xlsx", false);
		}

		private void save(string filename, bool message)
		{
			FileManager fileManager = new FileManager(filename);
			DataGridView dg = (DataGridView)form_panel.Controls[0].Controls["dataGridView"];

			fileManager.ExportToExcel(dg);
			if (message)
				MessageBox.Show("Файл сохранен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
