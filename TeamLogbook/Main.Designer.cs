namespace TeamLogbook
{
	partial class Main
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
			this.info_lb = new System.Windows.Forms.Label();
			this.lb_curr_file = new System.Windows.Forms.Label();
			this.lb_last_edit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// info_lb
			// 
			this.info_lb.AutoSize = true;
			this.info_lb.BackColor = System.Drawing.Color.Transparent;
			this.info_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.info_lb.ForeColor = System.Drawing.Color.Black;
			this.info_lb.Location = new System.Drawing.Point(244, 238);
			this.info_lb.Name = "info_lb";
			this.info_lb.Size = new System.Drawing.Size(551, 43);
			this.info_lb.TabIndex = 3;
			this.info_lb.Text = "Пока нет информации об файле";
			// 
			// lb_curr_file
			// 
			this.lb_curr_file.AutoSize = true;
			this.lb_curr_file.BackColor = System.Drawing.Color.Transparent;
			this.lb_curr_file.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.lb_curr_file.ForeColor = System.Drawing.Color.Black;
			this.lb_curr_file.Location = new System.Drawing.Point(244, 203);
			this.lb_curr_file.Name = "lb_curr_file";
			this.lb_curr_file.Size = new System.Drawing.Size(285, 43);
			this.lb_curr_file.TabIndex = 4;
			this.lb_curr_file.Text = "Текущий файл: ";
			// 
			// lb_last_edit
			// 
			this.lb_last_edit.AutoSize = true;
			this.lb_last_edit.BackColor = System.Drawing.Color.Transparent;
			this.lb_last_edit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.lb_last_edit.ForeColor = System.Drawing.Color.Black;
			this.lb_last_edit.Location = new System.Drawing.Point(244, 265);
			this.lb_last_edit.Name = "lb_last_edit";
			this.lb_last_edit.Size = new System.Drawing.Size(532, 43);
			this.lb_last_edit.TabIndex = 5;
			this.lb_last_edit.Text = "Последнее изменение было в:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.lb_last_edit);
			this.Controls.Add(this.lb_curr_file);
			this.Controls.Add(this.info_lb);
			this.MaximumSize = new System.Drawing.Size(1003, 558);
			this.MinimumSize = new System.Drawing.Size(1003, 558);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.Main_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label info_lb;
		private System.Windows.Forms.Label lb_curr_file;
		private System.Windows.Forms.Label lb_last_edit;
	}
}