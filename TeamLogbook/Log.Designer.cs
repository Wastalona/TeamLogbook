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
			this.btn_delete_col = new System.Windows.Forms.Button();
			this.btn_add_col = new System.Windows.Forms.Button();
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
			// btn_delete_col
			// 
			this.btn_delete_col.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_delete_col.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_delete_col.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_delete_col.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_delete_col.Location = new System.Drawing.Point(623, 0);
			this.btn_delete_col.Name = "btn_delete_col";
			this.btn_delete_col.Size = new System.Drawing.Size(158, 40);
			this.btn_delete_col.TabIndex = 7;
			this.btn_delete_col.Text = "Удалить столбец";
			this.btn_delete_col.UseVisualStyleBackColor = false;
			this.btn_delete_col.Click += new System.EventHandler(this.btn_delete_col_Click);
			// 
			// btn_add_col
			// 
			this.btn_add_col.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(158)))));
			this.btn_add_col.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_col.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_add_col.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(93)))));
			this.btn_add_col.Location = new System.Drawing.Point(787, 0);
			this.btn_add_col.Name = "btn_add_col";
			this.btn_add_col.Size = new System.Drawing.Size(173, 40);
			this.btn_add_col.TabIndex = 6;
			this.btn_add_col.Text = "Добавить столбец";
			this.btn_add_col.UseVisualStyleBackColor = false;
			this.btn_add_col.Click += new System.EventHandler(this.btn_add_col_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_add_col);
			this.panel1.Controls.Add(this.btn_delete_col);
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
		private System.Windows.Forms.Button btn_delete_col;
		private System.Windows.Forms.Button btn_add_col;
		private System.Windows.Forms.Panel panel1;
	}
}