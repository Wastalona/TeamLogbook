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
			this.SuspendLayout();
			// 
			// info_lb
			// 
			this.info_lb.AutoSize = true;
			this.info_lb.BackColor = System.Drawing.Color.Transparent;
			this.info_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.info_lb.ForeColor = System.Drawing.Color.Black;
			this.info_lb.Location = new System.Drawing.Point(242, 208);
			this.info_lb.Name = "info_lb";
			this.info_lb.Size = new System.Drawing.Size(513, 86);
			this.info_lb.TabIndex = 3;
			this.info_lb.Text = "Здесь отображается список \r\nучащихся, групп, предметов";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.info_lb);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label info_lb;
	}
}