namespace TeamLogbook
{
	partial class Log
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btn_top = new System.Windows.Forms.Button();
			this.btn_bottom = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowDrop = true;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(963, 449);
			this.dataGridView.TabIndex = 5;
			// 
			// btn_top
			// 
			this.btn_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_top.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_top.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_top.Location = new System.Drawing.Point(623, 0);
			this.btn_top.Name = "btn_top";
			this.btn_top.Size = new System.Drawing.Size(158, 40);
			this.btn_top.TabIndex = 7;
			this.btn_top.Text = "Перейти к верху";
			this.btn_top.UseVisualStyleBackColor = false;
			this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
			// 
			// btn_bottom
			// 
			this.btn_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_bottom.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_bottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_bottom.Location = new System.Drawing.Point(787, 0);
			this.btn_bottom.Name = "btn_bottom";
			this.btn_bottom.Size = new System.Drawing.Size(173, 40);
			this.btn_bottom.TabIndex = 6;
			this.btn_bottom.Text = "Перейти в конец";
			this.btn_bottom.UseVisualStyleBackColor = false;
			this.btn_bottom.Click += new System.EventHandler(this.btn_bottom_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_bottom);
			this.panel1.Controls.Add(this.btn_top);
			this.panel1.Location = new System.Drawing.Point(12, 467);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(963, 40);
			this.panel1.TabIndex = 8;
			// 
			// Log
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 519);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView);
			this.MaximumSize = new System.Drawing.Size(1003, 558);
			this.MinimumSize = new System.Drawing.Size(1003, 558);
			this.Name = "Log";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log";
			this.Load += new System.EventHandler(this.Log_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btn_top;
		private System.Windows.Forms.Button btn_bottom;
		private System.Windows.Forms.Panel panel1;
	}
}