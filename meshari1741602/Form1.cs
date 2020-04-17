using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meshari1741602
{
	public partial class Frmmain : Form
	{
		int x = 1;
		public Frmmain()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtuser.Text == "Mesh" && txtpassword.Text == "123")
			{
				MessageBox.Show("Login Successful");
			}
			else
			{
				MessageBox.Show("Login failed");
			}
			if (x >= 3)
			{
				MessageBox.Show("Program Terminated");
				Application.Exit();
			}
			if (txtuser.Text == "hi")
			{
				MessageBox.Show("WELCOME");
			}
			else
			{
				x++;
				MessageBox.Show("Invalid Password - Try Again");
				txtuser.Text = "";
			}
		}

		private void btnradio_Click(object sender, EventArgs e)
		{
			FrmRadio frm = new FrmRadio();
			frm.ShowDialog();
		}

		private void btncheckbox_Click(object sender, EventArgs e)
		{
			FrmCheckcs frm = new FrmCheckcs();
			frm.ShowDialog();
		}

		private void btnCombo_Click(object sender, EventArgs e)
		{
			FrmCombo frm = new FrmCombo();
			frm.ShowDialog();
		}

		private void btnRandomCombo_Click(object sender, EventArgs e)
		{
			FrmRandomCombo frm = new FrmRandomCombo();
			frm.ShowDialog();
		}

		private void btnRandom_Click(object sender, EventArgs e)
		{
			FrmRandom frm = new FrmRandom();
			frm.ShowDialog();
		}

		private void btnpicturebox_Click(object sender, EventArgs e)
		{
			FrmImage frm = new FrmImage();
			frm.ShowDialog();
		}

		private void ll_Enter(object sender, EventArgs e)
		{

		}

		private void Frmmain_Load(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnJohari_Click(object sender, EventArgs e)
		{

		}
	}
}
