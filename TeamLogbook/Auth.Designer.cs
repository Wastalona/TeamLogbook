namespace TeamLogbook
{
	partial class Auth
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
			this.head_lb = new System.Windows.Forms.Label();
			this.btn_auth = new System.Windows.Forms.Button();
			this.password_box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// head_lb
			// 
			this.head_lb.AutoSize = true;
			this.head_lb.BackColor = System.Drawing.Color.Transparent;
			this.head_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 28F, System.Drawing.FontStyle.Bold);
			this.head_lb.ForeColor = System.Drawing.Color.Black;
			this.head_lb.Location = new System.Drawing.Point(481, 203);
			this.head_lb.Name = "head_lb";
			this.head_lb.Size = new System.Drawing.Size(286, 50);
			this.head_lb.TabIndex = 2;
			this.head_lb.Text = "Team Logbook";
			// 
			// btn_auth
			// 
			this.btn_auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(36)))));
			this.btn_auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_auth.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_auth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_auth.Location = new System.Drawing.Point(490, 349);
			this.btn_auth.Name = "btn_auth";
			this.btn_auth.Size = new System.Drawing.Size(277, 53);
			this.btn_auth.TabIndex = 3;
			this.btn_auth.Text = "Подтвердить";
			this.btn_auth.UseVisualStyleBackColor = false;
			this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
			// 
			// password_box
			// 
			this.password_box.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.password_box.Location = new System.Drawing.Point(490, 292);
			this.password_box.MaxLength = 8;
			this.password_box.Name = "password_box";
			this.password_box.PasswordChar = '*';
			this.password_box.Size = new System.Drawing.Size(277, 35);
			this.password_box.TabIndex = 4;
			this.password_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(514, 253);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 21);
			this.label1.TabIndex = 5;
			this.label1.Text = "введите локальный пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(600, 405);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 21);
			this.label2.TabIndex = 6;
			this.label2.Text = "выйти";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Auth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password_box);
			this.Controls.Add(this.btn_auth);
			this.Controls.Add(this.head_lb);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1280, 720);
			this.MinimumSize = new System.Drawing.Size(1280, 720);
			this.Name = "Auth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label head_lb;
		private System.Windows.Forms.Button btn_auth;
		private System.Windows.Forms.TextBox password_box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}