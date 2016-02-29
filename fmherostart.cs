using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;


namespace acerclass
{
    public partial class fmherostart : Form
    {
        public fmherostart()
        {

            InitializeComponent();
            TextButton.Parent = this.PictureBoxWithBear;
            TextButton.BackColor = Color.Transparent;
            button1.Parent = this.PictureBoxWithBear;
            button1.BackColor = Color.Transparent;


        }

        private void fmherostart_Load(object sender, EventArgs e)
        {
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            fmSetupHero fm = new fmSetupHero();
            fm.ShowDialog();
            fm.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmHeroSelect fm = new fmHeroSelect();

            fm.ShowDialog();
            fm.Dispose();
        }
    }
}
