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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            PicTry1.Image = Image.FromFile("C:\\IE322_1741602\\meshari1741602\\WhatsApp Image 2020-04-17 at 5.57.43 PM.jpeg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
