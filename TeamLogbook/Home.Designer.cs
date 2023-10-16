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
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.fotter = new System.Windows.Forms.Panel();
			this.license_lb = new System.Windows.Forms.Label();
			this.version_lb = new System.Windows.Forms.Label();
			this.filter_panel = new System.Windows.Forms.Panel();
			this.body = new System.Windows.Forms.Panel();
			this.info_lb = new System.Windows.Forms.Label();
			this.control_panel = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_load = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_clear_all = new System.Windows.Forms.Button();
			this.btn_settings = new System.Windows.Forms.Button();
			this.header.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.menu.SuspendLayout();
			this.fotter.SuspendLayout();
			this.filter_panel.SuspendLayout();
			this.body.SuspendLayout();
			this.control_panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
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
			// 
			// comboBox3
			// 
			this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.comboBox3.Enabled = false;
			this.comboBox3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(8, 93);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(207, 36);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.Text = "Предмет";
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.comboBox2.Enabled = false;
			this.comboBox2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Учащийся"});
			this.comboBox2.Location = new System.Drawing.Point(8, 51);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(207, 36);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.Text = "Учащийся";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.comboBox1.Enabled = false;
			this.comboBox1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(8, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(207, 36);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Группа";
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
			this.filter_panel.Controls.Add(this.comboBox3);
			this.filter_panel.Controls.Add(this.comboBox1);
			this.filter_panel.Controls.Add(this.comboBox2);
			this.filter_panel.Location = new System.Drawing.Point(12, 99);
			this.filter_panel.Name = "filter_panel";
			this.filter_panel.Size = new System.Drawing.Size(223, 138);
			this.filter_panel.TabIndex = 1;
			// 
			// body
			// 
			this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.body.Controls.Add(this.info_lb);
			this.body.Location = new System.Drawing.Point(241, 99);
			this.body.Name = "body";
			this.body.Size = new System.Drawing.Size(1011, 518);
			this.body.TabIndex = 2;
			// 
			// info_lb
			// 
			this.info_lb.AutoSize = true;
			this.info_lb.BackColor = System.Drawing.Color.Transparent;
			this.info_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.info_lb.ForeColor = System.Drawing.Color.Black;
			this.info_lb.Location = new System.Drawing.Point(263, 199);
			this.info_lb.Name = "info_lb";
			this.info_lb.Size = new System.Drawing.Size(513, 86);
			this.info_lb.TabIndex = 2;
			this.info_lb.Text = "Здесь отображается список \r\nучащихся, групп, предметов";
			// 
			// control_panel
			// 
			this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
			this.control_panel.Controls.Add(this.flowLayoutPanel1);
			this.control_panel.Location = new System.Drawing.Point(12, 243);
			this.control_panel.Name = "control_panel";
			this.control_panel.Size = new System.Drawing.Size(223, 374);
			this.control_panel.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btn_load);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.btn_clear_all);
			this.flowLayoutPanel1.Controls.Add(this.btn_settings);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 350);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btn_load
			// 
			this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_load.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_load.Location = new System.Drawing.Point(3, 3);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(197, 60);
			this.btn_load.TabIndex = 1;
			this.btn_load.Text = "Загрузить файл";
			this.btn_load.UseVisualStyleBackColor = false;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.button1.Location = new System.Drawing.Point(3, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 60);
			this.button1.TabIndex = 3;
			this.button1.Text = "Изменить формат";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btn_clear_all
			// 
			this.btn_clear_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_clear_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_clear_all.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_clear_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_clear_all.Location = new System.Drawing.Point(3, 135);
			this.btn_clear_all.Name = "btn_clear_all";
			this.btn_clear_all.Size = new System.Drawing.Size(197, 60);
			this.btn_clear_all.TabIndex = 2;
			this.btn_clear_all.Text = "Очистить всё";
			this.btn_clear_all.UseVisualStyleBackColor = false;
			// 
			// btn_settings
			// 
			this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_settings.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_settings.Location = new System.Drawing.Point(3, 201);
			this.btn_settings.Name = "btn_settings";
			this.btn_settings.Size = new System.Drawing.Size(197, 60);
			this.btn_settings.TabIndex = 4;
			this.btn_settings.Text = "Настройки";
			this.btn_settings.UseVisualStyleBackColor = false;
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
			this.body.PerformLayout();
			this.control_panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label head_lb;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label license_lb;
		private System.Windows.Forms.Panel control_panel;
		private System.Windows.Forms.Label info_lb;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Button btn_clear_all;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_settings;
	}
}

