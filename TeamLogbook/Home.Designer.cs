namespace TeamLogbook
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.header = new System.Windows.Forms.Panel();
			this.head_lb = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.PictureBox();
			this.menu = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_main = new System.Windows.Forms.Button();
			this.btn_log = new System.Windows.Forms.Button();
			this.btn_progress = new System.Windows.Forms.Button();
			this.btn_pass = new System.Windows.Forms.Button();
			this.btn_report = new System.Windows.Forms.Button();
			this.subject_fl = new System.Windows.Forms.ComboBox();
			this.student_fl = new System.Windows.Forms.ComboBox();
			this.group_fl = new System.Windows.Forms.ComboBox();
			this.fotter = new System.Windows.Forms.Panel();
			this.license_lb = new System.Windows.Forms.Label();
			this.version_lb = new System.Windows.Forms.Label();
			this.filter_panel = new System.Windows.Forms.Panel();
			this.body = new System.Windows.Forms.Panel();
			this.form_panel = new System.Windows.Forms.Panel();
			this.btn_settings = new System.Windows.Forms.Button();
			this.control_panel = new System.Windows.Forms.Panel();
			this.panel_main = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_apply_fl = new System.Windows.Forms.Button();
			this.btn_load = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_save_as = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.menu.SuspendLayout();
			this.fotter.SuspendLayout();
			this.filter_panel.SuspendLayout();
			this.body.SuspendLayout();
			this.control_panel.SuspendLayout();
			this.panel_main.SuspendLayout();
			this.SuspendLayout();
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.header.Controls.Add(this.head_lb);
			this.header.Controls.Add(this.icon);
			this.header.Controls.Add(this.menu);
			this.header.Location = new System.Drawing.Point(-1, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(1265, 93);
			this.header.TabIndex = 0;
			// 
			// head_lb
			// 
			this.head_lb.AutoSize = true;
			this.head_lb.BackColor = System.Drawing.Color.Transparent;
			this.head_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.head_lb.ForeColor = System.Drawing.Color.Black;
			this.head_lb.Location = new System.Drawing.Point(99, 29);
			this.head_lb.Name = "head_lb";
			this.head_lb.Size = new System.Drawing.Size(247, 43);
			this.head_lb.TabIndex = 1;
			this.head_lb.Text = "Team Logbook";
			// 
			// icon
			// 
			this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
			this.icon.Location = new System.Drawing.Point(13, 9);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(80, 80);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 1;
			this.icon.TabStop = false;
			// 
			// menu
			// 
			this.menu.Controls.Add(this.btn_main);
			this.menu.Controls.Add(this.btn_log);
			this.menu.Controls.Add(this.btn_progress);
			this.menu.Controls.Add(this.btn_pass);
			this.menu.Controls.Add(this.btn_report);
			this.menu.Location = new System.Drawing.Point(421, 9);
			this.menu.Margin = new System.Windows.Forms.Padding(0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(835, 70);
			this.menu.TabIndex = 0;
			// 
			// btn_main
			// 
			this.btn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_main.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_main.Location = new System.Drawing.Point(3, 3);
			this.btn_main.Name = "btn_main";
			this.btn_main.Size = new System.Drawing.Size(160, 60);
			this.btn_main.TabIndex = 0;
			this.btn_main.Text = "Главная";
			this.btn_main.UseVisualStyleBackColor = false;
			this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
			// 
			// btn_log
			// 
			this.btn_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_log.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_log.Location = new System.Drawing.Point(169, 3);
			this.btn_log.Name = "btn_log";
			this.btn_log.Size = new System.Drawing.Size(160, 60);
			this.btn_log.TabIndex = 1;
			this.btn_log.Text = "Журнал";
			this.btn_log.UseVisualStyleBackColor = false;
			this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
			// 
			// btn_progress
			// 
			this.btn_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_progress.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_progress.Location = new System.Drawing.Point(335, 3);
			this.btn_progress.Name = "btn_progress";
			this.btn_progress.Size = new System.Drawing.Size(160, 60);
			this.btn_progress.TabIndex = 2;
			this.btn_progress.Text = "Успеваемость";
			this.btn_progress.UseVisualStyleBackColor = false;
			this.btn_progress.Click += new System.EventHandler(this.btn_progress_Click);
			// 
			// btn_pass
			// 
			this.btn_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_pass.Location = new System.Drawing.Point(501, 3);
			this.btn_pass.Name = "btn_pass";
			this.btn_pass.Size = new System.Drawing.Size(160, 60);
			this.btn_pass.TabIndex = 3;
			this.btn_pass.Text = "Пропуски";
			this.btn_pass.UseVisualStyleBackColor = false;
			this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
			// 
			// btn_report
			// 
			this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_report.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_report.Location = new System.Drawing.Point(667, 3);
			this.btn_report.Name = "btn_report";
			this.btn_report.Size = new System.Drawing.Size(160, 60);
			this.btn_report.TabIndex = 4;
			this.btn_report.Text = "Отчёт";
			this.btn_report.UseVisualStyleBackColor = false;
			this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
			// 
			// subject_fl
			// 
			this.subject_fl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.subject_fl.Enabled = false;
			this.subject_fl.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subject_fl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.subject_fl.FormattingEnabled = true;
			this.subject_fl.Location = new System.Drawing.Point(8, 93);
			this.subject_fl.Name = "subject_fl";
			this.subject_fl.Size = new System.Drawing.Size(207, 36);
			this.subject_fl.TabIndex = 3;
			this.subject_fl.Text = "Предмет";
			// 
			// student_fl
			// 
			this.student_fl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.student_fl.Enabled = false;
			this.student_fl.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.student_fl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.student_fl.FormattingEnabled = true;
			this.student_fl.Items.AddRange(new object[] {
            "Учащийся"});
			this.student_fl.Location = new System.Drawing.Point(8, 51);
			this.student_fl.Name = "student_fl";
			this.student_fl.Size = new System.Drawing.Size(207, 36);
			this.student_fl.TabIndex = 2;
			this.student_fl.Text = "Учащийся";
			// 
			// group_fl
			// 
			this.group_fl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.group_fl.Enabled = false;
			this.group_fl.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.group_fl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.group_fl.FormattingEnabled = true;
			this.group_fl.Location = new System.Drawing.Point(8, 9);
			this.group_fl.Name = "group_fl";
			this.group_fl.Size = new System.Drawing.Size(207, 36);
			this.group_fl.TabIndex = 1;
			this.group_fl.Text = "Группа";
			// 
			// fotter
			// 
			this.fotter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.fotter.Controls.Add(this.license_lb);
			this.fotter.Controls.Add(this.version_lb);
			this.fotter.Location = new System.Drawing.Point(-1, 623);
			this.fotter.Name = "fotter";
			this.fotter.Size = new System.Drawing.Size(1265, 61);
			this.fotter.TabIndex = 1;
			// 
			// license_lb
			// 
			this.license_lb.AutoSize = true;
			this.license_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.license_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.license_lb.ForeColor = System.Drawing.Color.Black;
			this.license_lb.Location = new System.Drawing.Point(7, 17);
			this.license_lb.Name = "license_lb";
			this.license_lb.Size = new System.Drawing.Size(280, 32);
			this.license_lb.TabIndex = 1;
			this.license_lb.Text = "©TeamLogbook - 2023";
			// 
			// version_lb
			// 
			this.version_lb.AutoSize = true;
			this.version_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.version_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8F, System.Drawing.FontStyle.Bold);
			this.version_lb.ForeColor = System.Drawing.Color.Black;
			this.version_lb.Location = new System.Drawing.Point(1180, 34);
			this.version_lb.Name = "version_lb";
			this.version_lb.Size = new System.Drawing.Size(73, 15);
			this.version_lb.TabIndex = 0;
			this.version_lb.Text = "version_1.0";
			// 
			// filter_panel
			// 
			this.filter_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.filter_panel.Controls.Add(this.subject_fl);
			this.filter_panel.Controls.Add(this.group_fl);
			this.filter_panel.Controls.Add(this.student_fl);
			this.filter_panel.Location = new System.Drawing.Point(12, 99);
			this.filter_panel.Name = "filter_panel";
			this.filter_panel.Size = new System.Drawing.Size(223, 138);
			this.filter_panel.TabIndex = 1;
			// 
			// body
			// 
			this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.body.Controls.Add(this.form_panel);
			this.body.Location = new System.Drawing.Point(241, 99);
			this.body.Name = "body";
			this.body.Size = new System.Drawing.Size(1011, 518);
			this.body.TabIndex = 2;
			// 
			// form_panel
			// 
			this.form_panel.Location = new System.Drawing.Point(3, 3);
			this.form_panel.Name = "form_panel";
			this.form_panel.Size = new System.Drawing.Size(1003, 512);
			this.form_panel.TabIndex = 3;
			// 
			// btn_settings
			// 
			this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_settings.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_settings.Location = new System.Drawing.Point(3, 267);
			this.btn_settings.Name = "btn_settings";
			this.btn_settings.Size = new System.Drawing.Size(197, 60);
			this.btn_settings.TabIndex = 4;
			this.btn_settings.Text = "Настройки";
			this.btn_settings.UseVisualStyleBackColor = false;
			this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
			// 
			// control_panel
			// 
			this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.control_panel.Controls.Add(this.panel_main);
			this.control_panel.Location = new System.Drawing.Point(12, 243);
			this.control_panel.Name = "control_panel";
			this.control_panel.Size = new System.Drawing.Size(223, 374);
			this.control_panel.TabIndex = 4;
			// 
			// panel_main
			// 
			this.panel_main.Controls.Add(this.btn_apply_fl);
			this.panel_main.Controls.Add(this.btn_load);
			this.panel_main.Controls.Add(this.btn_save);
			this.panel_main.Controls.Add(this.btn_save_as);
			this.panel_main.Controls.Add(this.btn_settings);
			this.panel_main.Location = new System.Drawing.Point(11, 12);
			this.panel_main.Name = "panel_main";
			this.panel_main.Size = new System.Drawing.Size(200, 350);
			this.panel_main.TabIndex = 0;
			// 
			// btn_apply_fl
			// 
			this.btn_apply_fl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_apply_fl.Enabled = false;
			this.btn_apply_fl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_apply_fl.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_apply_fl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_apply_fl.Location = new System.Drawing.Point(3, 3);
			this.btn_apply_fl.Name = "btn_apply_fl";
			this.btn_apply_fl.Size = new System.Drawing.Size(197, 60);
			this.btn_apply_fl.TabIndex = 2;
			this.btn_apply_fl.Text = "Применить фильтры";
			this.btn_apply_fl.UseVisualStyleBackColor = false;
			this.btn_apply_fl.Click += new System.EventHandler(this.btn_clear_all_Click);
			// 
			// btn_load
			// 
			this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_load.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_load.Location = new System.Drawing.Point(3, 69);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(197, 60);
			this.btn_load.TabIndex = 5;
			this.btn_load.Text = "Загрузить файл";
			this.btn_load.UseVisualStyleBackColor = false;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_save.Location = new System.Drawing.Point(3, 135);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(197, 60);
			this.btn_save.TabIndex = 1;
			this.btn_save.Text = "Сохранить файл";
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_save_as
			// 
			this.btn_save_as.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_save_as.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save_as.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_save_as.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_save_as.Location = new System.Drawing.Point(3, 201);
			this.btn_save_as.Name = "btn_save_as";
			this.btn_save_as.Size = new System.Drawing.Size(197, 60);
			this.btn_save_as.TabIndex = 6;
			this.btn_save_as.Text = "Сохранить как";
			this.btn_save_as.UseVisualStyleBackColor = false;
			this.btn_save_as.Click += new System.EventHandler(this.btn_save_as_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "xlsx";
			this.saveFileDialog1.FileName = "save.xlsx";
			this.saveFileDialog1.Title = "Сохранение файла";
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.control_panel);
			this.Controls.Add(this.body);
			this.Controls.Add(this.filter_panel);
			this.Controls.Add(this.fotter);
			this.Controls.Add(this.header);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главная";
			this.Load += new System.EventHandler(this.Home_Load);
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.menu.ResumeLayout(false);
			this.fotter.ResumeLayout(false);
			this.fotter.PerformLayout();
			this.filter_panel.ResumeLayout(false);
			this.body.ResumeLayout(false);
			this.control_panel.ResumeLayout(false);
			this.panel_main.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel fotter;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label version_lb;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_progress;
        private System.Windows.Forms.Button btn_pass;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.ComboBox subject_fl;
        private System.Windows.Forms.ComboBox student_fl;
        private System.Windows.Forms.ComboBox group_fl;
		private System.Windows.Forms.Label head_lb;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label license_lb;
		private System.Windows.Forms.Panel control_panel;
		private System.Windows.Forms.FlowLayoutPanel panel_main;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_apply_fl;
		private System.Windows.Forms.Button btn_settings;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Panel form_panel;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btn_save_as;
	}
}

