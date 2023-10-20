using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeamLogbook
{
	public partial class Options : Form
	{
		DBController db_controller = new DBController(); // Класс работы с дб
		string[] response;

		public Options()
		{
			InitializeComponent();
		}

		private void change_enable(bool isActive)
		/*
			Функция для активации и деактивации некоторых элементов
		*/
		{
			if (isActive)
			{
				lb_range.Enabled = true;
				box_range.Enabled = true;
				lb_path.Enabled = true;
				box_save_path.Enabled = true;
				btn_browse.Enabled = true;
			}
			else 
			{
				lb_range.Enabled = false;
				box_range.Enabled = false;
				lb_path.Enabled = false;
				box_save_path.Enabled = false;
				btn_browse.Enabled = false;
			}
		}

		private void Options_Load(object sender, EventArgs e)
		/*
			Подгрузка данных из бд на форму
		*/
		{
			response = db_controller.GetConfigData(); 

			if (response.Length == 7)  // Проверка, что у нас достаточно элементов в ответе
			{
				// Подгрузка для автосохранений
				is_autosaves.Checked = bool.Parse(response[3]);

				if (is_autosaves.Checked)
				{
					change_enable(true);
					box_save_path.Text = response[4];
					box_range.Text = response[5];
				}
				else
					change_enable(false);

				// Подгрузка для пароля
				if (bool.Parse(response[1]))
				{
					box_old_pass.Enabled = true;
					lb_old_pass.Enabled = true;
				}
			}
			else
			{
				MessageBox.Show("Некорректный ответ из базы данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_browse_Click(object sender, EventArgs e)
		/*
			Функция для кнопки "Обзор". Выбора пути до места сохранения
		*/
		{
			DialogResult result = folderBrowserDialog1.ShowDialog();

			// Если пользователь выбрал путь, показываем выбранный путь
			if (result == DialogResult.OK)
			{
				string selectedPath = folderBrowserDialog1.SelectedPath;
				box_save_path.Text = selectedPath;
			}
		}

		private void btn_save_Click(object sender, EventArgs e)
		/*
			Функция сохранения информации об автосохранениях
		*/
		{
			if (is_autosaves.Checked)
				db_controller.SaveAutosavesSettings(true, box_save_path.Text, box_range.Text);
			else
				db_controller.SaveAutosavesSettings(false, box_save_path.Text, box_range.Text);
		}

		private void UpdateAutosavesBlock(object sender, EventArgs e)
		/*
			Обновление элементов, связанных с автосохранениями для чекбокса	
		*/
		{
			change_enable(is_autosaves.Checked);
		}

		private void btn_change_pass_Click(object sender, EventArgs e)
		/*
			Функция для кнопки сохранения пароля. Тут же вся проверка 
		*/
		{
			void change_password()
			{
				string newPassword = box_pass.Text;
				string confirmedPassword = box_sub_pass.Text;

				if (newPassword != "" && confirmedPassword != "") {
					// Проверка совпадения паролей
					if (newPassword == confirmedPassword)
					{
						string hashedPassword = db_controller.HashPassword(newPassword);
						if (db_controller.update_config_value(hashedPassword, "PasswordHash"))
						{
							db_controller.update_config_value("1", "isActive");
							MessageBox.Show("Пароль сменён", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else
							MessageBox.Show("Не удалось сменить или установить пароль", "Ошибка смены пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
						MessageBox.Show("Пароли не совпадают", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					db_controller.update_config_value("0", "isActive");
					MessageBox.Show("Пароль убран", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			if (bool.Parse(response[1])) // нужно ли вводить старый пароль
			{
				if (db_controller.CheckPassword(box_old_pass.Text))
					change_password();
				else
					MessageBox.Show("Страрый пароль не совпадает", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				change_password();
		}
	}
}
