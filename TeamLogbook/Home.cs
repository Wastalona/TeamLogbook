using NPOI.SS.UserModel;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamLogbook
{
    public partial class Home : Form
    {
		private bool use_local_password = true;
		private string local_password = "11110000"; // локальный пароль
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

		private void Home_Load(object sender, EventArgs e)
		{
			PanelForm(new Main());
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
				btn_change_format.Enabled = true;
				btn_settings.Enabled = true;
			}
			else{ 
				btn_load.Enabled = false;
				btn_save.Enabled = false;
				btn_change_format.Enabled = false;
				btn_settings.Enabled = false;
			}
		}

		// Кнопки меню
		private void btn_main_Click(object sender, EventArgs e)
		{
			PanelForm(new Main());
			filters_panel(false);
			main_panel(true);
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


		private void btn_change_format_Click(object sender, EventArgs e)
		{
			PanelForm(new ExcelLoadForms());
			filters_panel(false);
			main_panel(false);
		}

		private void btn_clear_all_Click(object sender, EventArgs e)
		{
			MessageBox.Show(form_panel.Controls[0].Text);
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			string filename = saveFileDialog1.FileName; // получаем выбранный файл
			//File.WriteAllText(filename, textToSave); // сохраняем текст в файл
			MessageBox.Show("Файл сохранен");
		}
	}
}
