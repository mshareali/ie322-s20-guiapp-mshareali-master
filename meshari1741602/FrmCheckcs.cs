﻿using System;
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
    public partial class FrmCheckcs : Form
    {
        public FrmCheckcs()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (Chkcoffe.Checked == true)
            {
                msg = Chkcoffe.Text;
            }
            if (chkDounat.Checked == true)
            {
                msg = msg + chkDounat.Text;
            }
            if (chkBrownie.Checked == true)
            {
                msg = msg + chkBrownie.Text;
            }

            if (msg.Length == 0)
            {
                msg = "nothing selected";
            }
            MessageBox.Show(msg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCheckcs_Load(object sender, EventArgs e)
        {

        }
    }
}
