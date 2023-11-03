namespace TeamLogbook
{
	partial class Report
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
			this.pieChart = new LiveCharts.WinForms.PieChart();
			this.head_lb = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pieChart
			// 
			this.pieChart.Location = new System.Drawing.Point(12, 12);
			this.pieChart.Name = "pieChart";
			this.pieChart.Size = new System.Drawing.Size(963, 394);
			this.pieChart.TabIndex = 0;
			this.pieChart.Text = "pieChart1";
			// 
			// head_lb
			// 
			this.head_lb.AutoSize = true;
			this.head_lb.BackColor = System.Drawing.Color.Transparent;
			this.head_lb.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 24F, System.Drawing.FontStyle.Bold);
			this.head_lb.ForeColor = System.Drawing.Color.Black;
			this.head_lb.Location = new System.Drawing.Point(358, 452);
			this.head_lb.Name = "head_lb";
			this.head_lb.Size = new System.Drawing.Size(285, 43);
			this.head_lb.TabIndex = 2;
			this.head_lb.Text = "Отчёт за месяц";
			// 
			// Report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.head_lb);
			this.Controls.Add(this.pieChart);
			this.MaximumSize = new System.Drawing.Size(1003, 558);
			this.MinimumSize = new System.Drawing.Size(1003, 558);
			this.Name = "Report";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report";
			this.Load += new System.EventHandler(this.Report_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private LiveCharts.WinForms.PieChart pieChart;
		private System.Windows.Forms.Label head_lb;
	}
}