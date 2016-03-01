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
    public partial class fmdavinci : Form
    {
        public fmdavinci()
        {
            InitializeComponent();
        }

        public string FormatLunarYear(int iYear)
        {
            string strYear;
            string szText1 = "甲乙丙丁戊己庚辛壬癸";
            string szText2 = "子丑寅卯辰巳午未申酉戌亥";
            string szText3 = "鼠牛虎免龍蛇馬羊猴雞狗豬";

            strYear = szText1.Substring((iYear - 4) % 10, 1);
            strYear = strYear + szText2.Substring((iYear - 4) % 12, 1);
            strYear = strYear + " ";
            strYear = strYear + szText3.Substring((iYear - 4) % 12, 1);
            strYear = strYear + "年";
            return strYear;
        }

        public string FormatMonth(int iMonth)
        {
            string szText = "一二三四五六七八九十";
            string strMonth;



            if (iMonth <= 10)
            {
                strMonth = "";
                strMonth = strMonth + szText.Substring(iMonth - 1, 1);
                strMonth = strMonth;
                return strMonth;
            }

            if (iMonth == 11)
            {
                strMonth = "十一";
            }
            else
            {
                strMonth = "十二";
            }
            return strMonth;
        }


        public string FormatDay(int iDay)
        {
            string szText = "一二三四五六七八九十";
            string strMonth;


            if (iDay <= 19)
            {
                strMonth = "";
                strMonth = strMonth + szText.Substring(iDay - 1, 1);
                return strMonth;
            }
            else
            {
                int ida = (int)Math.Truncate((double)iDay / 10);
                int idb = iDay - ida * 10;
                strMonth = szText.Substring(ida - 1, 1) + "十" + szText.Substring(idb - 1, 1);
            }


            return strMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> strlist = new List<string>();

            DateTime dt = DateTime.Now;


            string sdate = string.Format("{0}年{1}月{2}日", FormatLunarYear(dt.Year), FormatMonth(dt.Month), FormatDay(dt.Day));

            listboxyear.Items.Clear();
            foreach (char ch in sdate)
            {
                listboxyear.Items.Add(ch.ToString());
            }

            List<string> slist = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                slist.Add(listBox1.Items[i].ToString());
            }
            StringBuilder sb = slist.Select(s => s).Aggregate(new StringBuilder(), (ag, n) => ag.Append(n).Append(","));
            if (sb.Length > 0)
            {
                listBox1.Items.Clear();
                string restr = string.Format(sb.ToString(), eda1.Text, eda2.Text, eda3.Text, eda4.Text);
                listBox1.Items.AddRange(restr.Split(new char[] { ',' }));
            }



            //listBox1.Items = string.Format(str, eda1.Text, eda2.Text, eda3.Text, eda4.Text);

        }
    }
}
