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
    public partial class fminitiald : Form
    {
        public fminitiald()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string strSource = textBox1.Text;
            
            

            string[] strDelimiters = new string[] { "善" };
            string[] stringArray = strSource.Split(strDelimiters,StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stringArray.Length; i++)
            {
                listBox1.Items.Add("善"+stringArray[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char ch in textBox1.Text)
            {
                if (ch.ToString() == "善")
                {
                    sb.AppendLine("");
                    sb.Append(ch.ToString());
                }
                else
                {
                    sb.Append(ch);
                }
            }

            char[] strDelimiters = new char[] { '\r', '\n' };

            string[] strArray = sb.ToString().Split(strDelimiters,StringSplitOptions.RemoveEmptyEntries);

            listBox1.Items.Clear();
            foreach (string strRow in strArray)
            {
                listBox1.Items.Add(strRow);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> strList = new List<string>();

            string[] strDelimiters = new string[] { "善" };
            string[] stringArray = textBox1.Text.Split(strDelimiters, StringSplitOptions.RemoveEmptyEntries);

            strList = stringArray.ToList<string>();

            foreach (string str in strList)
            {
                listBox1.Items.Add(str);
            }

            
        }

        private bool IsInitailNice(char ch)
        {
            if (ch.ToString() == "善")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
