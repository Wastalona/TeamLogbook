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
	public partial class Log : Form
	{
		private static bool isOpen = false;
		public Log(bool open)
		{
			InitializeComponent();
			isOpen = open;
		}

		private void Log_Load(object sender, EventArgs e)
		{
			if (!isOpen)
				dataGridView.Hide();
		}
	}
}
