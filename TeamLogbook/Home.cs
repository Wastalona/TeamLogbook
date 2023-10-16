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
    public partial class Home : Form
    {
		private bool use_local_password = true;
		private string local_password = "11110000";

		public Home()
        {
            InitializeComponent();
        }

		private void btn_load_Click(object sender, EventArgs e)
		{

		}

		private void Home_Load(object sender, EventArgs e)
		{
			this.Hide();
			if (use_local_password)
			{
				Auth auth_form = new Auth(local_password);
				this.Hide();
				auth_form.Show();
			}
		}
	}
}
