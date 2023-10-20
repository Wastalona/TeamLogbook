using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamLogbook
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			lb_last_edit.Hide();
			lb_curr_file.Hide();
		}
	}
}
