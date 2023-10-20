namespace TeamLogbook
{
	partial class ExcelLoadForms
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
			this.header = new System.Windows.Forms.Label();
			this.subheader = new System.Windows.Forms.Label();
			this.panel_standart = new System.Windows.Forms.Panel();
			this.lb_standart = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel_custom = new System.Windows.Forms.Panel();
			this.lb_custom = new System.Windows.Forms.Label();
			this.btn_apply_custom = new System.Windows.Forms.Button();
			this.btn_apply_standart = new System.Windows.Forms.Button();
			this.panel_standart.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel_custom.SuspendLayout();
			this.SuspendLayout();
			// 
			// header
			// 
			this.header.AutoSize = true;
			this.header.BackColor = System.Drawing.Color.Transparent;
			this.header.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.header.ForeColor = System.Drawing.Color.Black;
			this.header.Location = new System.Drawing.Point(12, 9);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(513, 43);
			this.header.TabIndex = 5;
			this.header.Text = "Здесь можно изменить форму";
			// 
			// subheader
			// 
			this.subheader.AutoSize = true;
			this.subheader.BackColor = System.Drawing.Color.Transparent;
			this.subheader.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold);
			this.subheader.ForeColor = System.Drawing.Color.Black;
			this.subheader.Location = new System.Drawing.Point(94, 52);
			this.subheader.Name = "subheader";
			this.subheader.Size = new System.Drawing.Size(298, 21);
			this.subheader.TabIndex = 6;
			this.subheader.Text = "в которой загружается excel файл";
			// 
			// panel_standart
			// 
			this.panel_standart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.panel_standart.Controls.Add(this.panel3);
			this.panel_standart.Controls.Add(this.panel4);
			this.panel_standart.Controls.Add(this.panel2);
			this.panel_standart.Controls.Add(this.panel1);
			this.panel_standart.Controls.Add(this.lb_standart);
			this.panel_standart.Location = new System.Drawing.Point(20, 100);
			this.panel_standart.Name = "panel_standart";
			this.panel_standart.Size = new System.Drawing.Size(542, 313);
			this.panel_standart.TabIndex = 7;
			// 
			// lb_standart
			// 
			this.lb_standart.AutoSize = true;
			this.lb_standart.BackColor = System.Drawing.Color.Transparent;
			this.lb_standart.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.lb_standart.ForeColor = System.Drawing.Color.Black;
			this.lb_standart.Location = new System.Drawing.Point(98, 20);
			this.lb_standart.Name = "lb_standart";
			this.lb_standart.Size = new System.Drawing.Size(342, 43);
			this.lb_standart.TabIndex = 8;
			this.lb_standart.Text = "Стнадартная форма";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(17, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "ФИО учащегося";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(9, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 32);
			this.label3.TabIndex = 10;
			this.label3.Text = "Даты выполнения";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(33, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(236, 100);
			this.panel1.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(269, 77);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(236, 100);
			this.panel2.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(269, 177);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(236, 100);
			this.panel3.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(62, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 32);
			this.label4.TabIndex = 10;
			this.label4.Text = "Оценка";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(33, 177);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(236, 100);
			this.panel4.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(91, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 32);
			this.label6.TabIndex = 9;
			this.label6.Text = "ФИО";
			// 
			// panel_custom
			// 
			this.panel_custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.panel_custom.Controls.Add(this.lb_custom);
			this.panel_custom.Location = new System.Drawing.Point(581, 100);
			this.panel_custom.Name = "panel_custom";
			this.panel_custom.Size = new System.Drawing.Size(382, 313);
			this.panel_custom.TabIndex = 15;
			// 
			// lb_custom
			// 
			this.lb_custom.AutoSize = true;
			this.lb_custom.BackColor = System.Drawing.Color.Transparent;
			this.lb_custom.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.lb_custom.ForeColor = System.Drawing.Color.Black;
			this.lb_custom.Location = new System.Drawing.Point(94, 20);
			this.lb_custom.Name = "lb_custom";
			this.lb_custom.Size = new System.Drawing.Size(209, 43);
			this.lb_custom.TabIndex = 8;
			this.lb_custom.Text = "Ваша форма";
			// 
			// btn_apply_custom
			// 
			this.btn_apply_custom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(87)))), ((int)(((byte)(66)))));
			this.btn_apply_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_apply_custom.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.btn_apply_custom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(201)))), ((int)(((byte)(153)))));
			this.btn_apply_custom.Location = new System.Drawing.Point(683, 433);
			this.btn_apply_custom.Name = "btn_apply_custom";
			this.btn_apply_custom.Size = new System.Drawing.Size(201, 49);
			this.btn_apply_custom.TabIndex = 16;
			this.btn_apply_custom.Text = "Применить";
			this.btn_apply_custom.UseVisualStyleBackColor = false;
			this.btn_apply_custom.Click += new System.EventHandler(this.btn_apply_custom_Click);
			// 
			// btn_apply_standart
			// 
			this.btn_apply_standart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(201)))), ((int)(((byte)(153)))));
			this.btn_apply_standart.Enabled = false;
			this.btn_apply_standart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_apply_standart.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
			this.btn_apply_standart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.btn_apply_standart.Location = new System.Drawing.Point(191, 433);
			this.btn_apply_standart.Name = "btn_apply_standart";
			this.btn_apply_standart.Size = new System.Drawing.Size(201, 49);
			this.btn_apply_standart.TabIndex = 17;
			this.btn_apply_standart.Text = "Применяется";
			this.btn_apply_standart.UseVisualStyleBackColor = false;
			this.btn_apply_standart.Click += new System.EventHandler(this.btn_apply_standart_Click);
			// 
			// ExcelLoadForms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.btn_apply_standart);
			this.Controls.Add(this.btn_apply_custom);
			this.Controls.Add(this.panel_custom);
			this.Controls.Add(this.panel_standart);
			this.Controls.Add(this.subheader);
			this.Controls.Add(this.header);
			this.MaximumSize = new System.Drawing.Size(1003, 558);
			this.MinimumSize = new System.Drawing.Size(1003, 558);
			this.Name = "ExcelLoadForms";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ExcelLoadForms";
			this.Load += new System.EventHandler(this.ExcelLoadForms_Load);
			this.panel_standart.ResumeLayout(false);
			this.panel_standart.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel_custom.ResumeLayout(false);
			this.panel_custom.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label header;
		private System.Windows.Forms.Label subheader;
		private System.Windows.Forms.Panel panel_standart;
		private System.Windows.Forms.Label lb_standart;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel_custom;
		private System.Windows.Forms.Label lb_custom;
		private System.Windows.Forms.Button btn_apply_custom;
		private System.Windows.Forms.Button btn_apply_standart;
	}
}