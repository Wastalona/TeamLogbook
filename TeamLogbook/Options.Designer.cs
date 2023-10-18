namespace TeamLogbook
{
	partial class Options
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btn_change_pass = new System.Windows.Forms.Button();
			this.Security_header = new System.Windows.Forms.Label();
			this.box_old_pass = new System.Windows.Forms.TextBox();
			this.box_pass = new System.Windows.Forms.TextBox();
			this.lb_old_pass = new System.Windows.Forms.Label();
			this.box_sub_pass = new System.Windows.Forms.TextBox();
			this.lb_pass = new System.Windows.Forms.Label();
			this.lb_sub_pass = new System.Windows.Forms.Label();
			this.pass_req_lb = new System.Windows.Forms.Label();
			this.panel_security = new System.Windows.Forms.Panel();
			this.about_app_header = new System.Windows.Forms.Label();
			this.panel_about = new System.Windows.Forms.Panel();
			this.list_info = new System.Windows.Forms.ListBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.box_range = new System.Windows.Forms.TextBox();
			this.lb_range = new System.Windows.Forms.Label();
			this.box_save_path = new System.Windows.Forms.TextBox();
			this.lb_path = new System.Windows.Forms.Label();
			this.panel_autosaves = new System.Windows.Forms.Panel();
			this.lb_req_range = new System.Windows.Forms.Label();
			this.is_autosaves = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btn_browse = new System.Windows.Forms.Button();
			this.panel_security.SuspendLayout();
			this.panel_about.SuspendLayout();
			this.panel_autosaves.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_change_pass
			// 
			this.btn_change_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(77)))));
			this.btn_change_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_change_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.btn_change_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
			this.btn_change_pass.Location = new System.Drawing.Point(36, 383);
			this.btn_change_pass.Name = "btn_change_pass";
			this.btn_change_pass.Size = new System.Drawing.Size(211, 49);
			this.btn_change_pass.TabIndex = 0;
			this.btn_change_pass.Text = "Сменить пароль";
			this.btn_change_pass.UseVisualStyleBackColor = false;
			this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
			// 
			// Security_header
			// 
			this.Security_header.AutoSize = true;
			this.Security_header.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.Security_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.Security_header.Location = new System.Drawing.Point(40, 9);
			this.Security_header.Name = "Security_header";
			this.Security_header.Size = new System.Drawing.Size(247, 43);
			this.Security_header.TabIndex = 1;
			this.Security_header.Text = "Безопасность";
			// 
			// box_old_pass
			// 
			this.box_old_pass.Enabled = false;
			this.box_old_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.box_old_pass.Location = new System.Drawing.Point(8, 38);
			this.box_old_pass.MaxLength = 4;
			this.box_old_pass.Name = "box_old_pass";
			this.box_old_pass.PasswordChar = '*';
			this.box_old_pass.Size = new System.Drawing.Size(180, 32);
			this.box_old_pass.TabIndex = 2;
			this.box_old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// box_pass
			// 
			this.box_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.box_pass.Location = new System.Drawing.Point(8, 104);
			this.box_pass.MaxLength = 4;
			this.box_pass.Name = "box_pass";
			this.box_pass.PasswordChar = '*';
			this.box_pass.Size = new System.Drawing.Size(180, 32);
			this.box_pass.TabIndex = 4;
			this.box_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lb_old_pass
			// 
			this.lb_old_pass.AutoSize = true;
			this.lb_old_pass.Enabled = false;
			this.lb_old_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_old_pass.Location = new System.Drawing.Point(3, 7);
			this.lb_old_pass.Name = "lb_old_pass";
			this.lb_old_pass.Size = new System.Drawing.Size(264, 28);
			this.lb_old_pass.TabIndex = 3;
			this.lb_old_pass.Text = "Введите старый пароль";
			// 
			// box_sub_pass
			// 
			this.box_sub_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.box_sub_pass.Location = new System.Drawing.Point(8, 170);
			this.box_sub_pass.MaxLength = 4;
			this.box_sub_pass.Name = "box_sub_pass";
			this.box_sub_pass.PasswordChar = '*';
			this.box_sub_pass.Size = new System.Drawing.Size(180, 32);
			this.box_sub_pass.TabIndex = 6;
			this.box_sub_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lb_pass
			// 
			this.lb_pass.AutoSize = true;
			this.lb_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_pass.Location = new System.Drawing.Point(3, 73);
			this.lb_pass.Name = "lb_pass";
			this.lb_pass.Size = new System.Drawing.Size(180, 28);
			this.lb_pass.TabIndex = 5;
			this.lb_pass.Text = "Введите пароль";
			// 
			// lb_sub_pass
			// 
			this.lb_sub_pass.AutoSize = true;
			this.lb_sub_pass.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_sub_pass.Location = new System.Drawing.Point(3, 139);
			this.lb_sub_pass.Name = "lb_sub_pass";
			this.lb_sub_pass.Size = new System.Drawing.Size(228, 28);
			this.lb_sub_pass.TabIndex = 8;
			this.lb_sub_pass.Text = "Подтвердите пароль";
			// 
			// pass_req_lb
			// 
			this.pass_req_lb.AutoSize = true;
			this.pass_req_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.pass_req_lb.Location = new System.Drawing.Point(3, 217);
			this.pass_req_lb.Name = "pass_req_lb";
			this.pass_req_lb.Size = new System.Drawing.Size(312, 56);
			this.pass_req_lb.TabIndex = 10;
			this.pass_req_lb.Text = "! Пароль должен состоять \r\nиз 4 символов";
			// 
			// panel_security
			// 
			this.panel_security.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.panel_security.Controls.Add(this.pass_req_lb);
			this.panel_security.Controls.Add(this.lb_old_pass);
			this.panel_security.Controls.Add(this.btn_change_pass);
			this.panel_security.Controls.Add(this.box_old_pass);
			this.panel_security.Controls.Add(this.lb_pass);
			this.panel_security.Controls.Add(this.box_sub_pass);
			this.panel_security.Controls.Add(this.box_pass);
			this.panel_security.Controls.Add(this.lb_sub_pass);
			this.panel_security.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.panel_security.Location = new System.Drawing.Point(12, 55);
			this.panel_security.Name = "panel_security";
			this.panel_security.Size = new System.Drawing.Size(305, 452);
			this.panel_security.TabIndex = 13;
			// 
			// about_app_header
			// 
			this.about_app_header.AutoSize = true;
			this.about_app_header.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.about_app_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.about_app_header.Location = new System.Drawing.Point(378, 9);
			this.about_app_header.Name = "about_app_header";
			this.about_app_header.Size = new System.Drawing.Size(266, 43);
			this.about_app_header.TabIndex = 14;
			this.about_app_header.Text = "Об приложении";
			// 
			// panel_about
			// 
			this.panel_about.Controls.Add(this.list_info);
			this.panel_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.panel_about.Location = new System.Drawing.Point(377, 55);
			this.panel_about.Name = "panel_about";
			this.panel_about.Size = new System.Drawing.Size(598, 123);
			this.panel_about.TabIndex = 17;
			// 
			// list_info
			// 
			this.list_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.list_info.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.list_info.FormattingEnabled = true;
			this.list_info.ItemHeight = 28;
			this.list_info.Items.AddRange(new object[] {
            "TeamLogbook - электронный журнал, основная цель ",
            "которого – упростить работу преподавателей ",
            "образовательного учреждения по контролю знаний ",
            "учащихся."});
			this.list_info.Location = new System.Drawing.Point(0, 0);
			this.list_info.Name = "list_info";
			this.list_info.Size = new System.Drawing.Size(598, 116);
			this.list_info.TabIndex = 18;
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
			this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(201)))), ((int)(((byte)(153)))));
			this.btn_save.Location = new System.Drawing.Point(133, 195);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(211, 49);
			this.btn_save.TabIndex = 0;
			this.btn_save.Text = "Сохранить";
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// box_range
			// 
			this.box_range.Enabled = false;
			this.box_range.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.box_range.Location = new System.Drawing.Point(9, 79);
			this.box_range.MaxLength = 3;
			this.box_range.Name = "box_range";
			this.box_range.Size = new System.Drawing.Size(109, 32);
			this.box_range.TabIndex = 2;
			this.box_range.Text = "15";
			this.box_range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lb_range
			// 
			this.lb_range.AutoSize = true;
			this.lb_range.Enabled = false;
			this.lb_range.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_range.Location = new System.Drawing.Point(4, 48);
			this.lb_range.Name = "lb_range";
			this.lb_range.Size = new System.Drawing.Size(480, 28);
			this.lb_range.TabIndex = 5;
			this.lb_range.Text = "Интервал между сохранениями (в минутах)";
			// 
			// box_save_path
			// 
			this.box_save_path.Enabled = false;
			this.box_save_path.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold);
			this.box_save_path.Location = new System.Drawing.Point(9, 157);
			this.box_save_path.MaxLength = 99999;
			this.box_save_path.Name = "box_save_path";
			this.box_save_path.Size = new System.Drawing.Size(353, 29);
			this.box_save_path.TabIndex = 6;
			// 
			// lb_path
			// 
			this.lb_path.AutoSize = true;
			this.lb_path.Enabled = false;
			this.lb_path.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_path.Location = new System.Drawing.Point(4, 126);
			this.lb_path.Name = "lb_path";
			this.lb_path.Size = new System.Drawing.Size(192, 28);
			this.lb_path.TabIndex = 8;
			this.lb_path.Text = "Куда сохранять?";
			// 
			// panel_autosaves
			// 
			this.panel_autosaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.panel_autosaves.Controls.Add(this.lb_req_range);
			this.panel_autosaves.Controls.Add(this.is_autosaves);
			this.panel_autosaves.Controls.Add(this.lb_range);
			this.panel_autosaves.Controls.Add(this.btn_save);
			this.panel_autosaves.Controls.Add(this.box_range);
			this.panel_autosaves.Controls.Add(this.lb_path);
			this.panel_autosaves.Controls.Add(this.box_save_path);
			this.panel_autosaves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.panel_autosaves.Location = new System.Drawing.Point(377, 256);
			this.panel_autosaves.Name = "panel_autosaves";
			this.panel_autosaves.Size = new System.Drawing.Size(487, 251);
			this.panel_autosaves.TabIndex = 19;
			// 
			// lb_req_range
			// 
			this.lb_req_range.AutoSize = true;
			this.lb_req_range.Enabled = false;
			this.lb_req_range.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.lb_req_range.Location = new System.Drawing.Point(128, 82);
			this.lb_req_range.Name = "lb_req_range";
			this.lb_req_range.Size = new System.Drawing.Size(276, 28);
			this.lb_req_range.TabIndex = 22;
			this.lb_req_range.Text = "( 0 < значение <= 120)";
			// 
			// is_autosaves
			// 
			this.is_autosaves.AutoSize = true;
			this.is_autosaves.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.is_autosaves.Location = new System.Drawing.Point(9, 13);
			this.is_autosaves.Name = "is_autosaves";
			this.is_autosaves.Size = new System.Drawing.Size(307, 32);
			this.is_autosaves.TabIndex = 21;
			this.is_autosaves.Text = "Включить автосохранения";
			this.is_autosaves.UseVisualStyleBackColor = true;
			this.is_autosaves.Click += new System.EventHandler(this.UpdateAutosavesBlock);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(34)))), ((int)(((byte)(32)))));
			this.label2.Location = new System.Drawing.Point(378, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(285, 43);
			this.label2.TabIndex = 20;
			this.label2.Text = "Автосохранения";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Выберите папку, в которую будут загружаться автосохранения";
			this.folderBrowserDialog1.SelectedPath = ".\\autosaves\\";
			// 
			// btn_browse
			// 
			this.btn_browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
			this.btn_browse.Enabled = false;
			this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_browse.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.btn_browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(201)))), ((int)(((byte)(153)))));
			this.btn_browse.Location = new System.Drawing.Point(745, 413);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(104, 32);
			this.btn_browse.TabIndex = 22;
			this.btn_browse.Text = "обзор";
			this.btn_browse.UseVisualStyleBackColor = false;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.btn_browse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel_autosaves);
			this.Controls.Add(this.panel_about);
			this.Controls.Add(this.about_app_header);
			this.Controls.Add(this.Security_header);
			this.Controls.Add(this.panel_security);
			this.Name = "Options";
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.panel_security.ResumeLayout(false);
			this.panel_security.PerformLayout();
			this.panel_about.ResumeLayout(false);
			this.panel_autosaves.ResumeLayout(false);
			this.panel_autosaves.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btn_change_pass;
		private System.Windows.Forms.Label Security_header;
		private System.Windows.Forms.TextBox box_old_pass;
		private System.Windows.Forms.TextBox box_pass;
		private System.Windows.Forms.Label lb_old_pass;
		private System.Windows.Forms.TextBox box_sub_pass;
		private System.Windows.Forms.Label lb_pass;
		private System.Windows.Forms.Label lb_sub_pass;
		private System.Windows.Forms.Label pass_req_lb;
		private System.Windows.Forms.Panel panel_security;
		private System.Windows.Forms.Label about_app_header;
		private System.Windows.Forms.Panel panel_about;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.TextBox box_range;
		private System.Windows.Forms.Label lb_range;
		private System.Windows.Forms.TextBox box_save_path;
		private System.Windows.Forms.Label lb_path;
		private System.Windows.Forms.ListBox list_info;
		private System.Windows.Forms.Panel panel_autosaves;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox is_autosaves;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btn_browse;
		private System.Windows.Forms.Label lb_req_range;
	}
}