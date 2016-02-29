using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acerclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fminitiald fm = new fminitiald();
            fm.ShowDialog();
            fm.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fmdavinci fm = new fmdavinci();
            fm.ShowDialog();
            fm.Dispose();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            fmherostart fm = new fmherostart();
            fm.ShowDialog();
            fm.Dispose();
        }
    }
}
