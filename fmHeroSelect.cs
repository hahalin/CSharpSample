using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace acerclass
{
    public partial class fmHeroSelect : Form
    {
        private List<Hero> HeroList;

        public fmHeroSelect()
        {
            InitializeComponent();

            HeroList = new List<Hero>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            OpenFileDialog Opendlg = new OpenFileDialog();

            if (Opendlg.ShowDialog(this) == DialogResult.OK)
            {

                string fileData = System.IO.File.ReadAllText(Opendlg.FileName);

                JArray HerosArray = ((JObject)JsonConvert.DeserializeObject(fileData))["data"] as JArray;

                listBox1.Items.Clear();



                for (int i = 0; i < HerosArray.Count; i++)
                {
                    JObject tmpObj = (JObject)HerosArray[i];

                    var HeroData = JsonConvert.DeserializeObject<dynamic>(tmpObj.ToString());

                    #region dserilaize heros

                    Hero theHero = new Hero();

                    theHero.cname = HeroData.cname;
                    theHero.ename = HeroData.ename;
                    theHero.slogan = HeroData.slogan;
                    theHero.photoFilename = HeroData.photoFilename;
                    theHero.HGroup = Enum.Parse(typeof(HeroGroup), System.Convert.ToString(HeroData.group));

                    var tmpArray = HeroData.abilities;

                    foreach (var obj in tmpArray)
                    {
                        theHero.abilities.Add((HeroAbility)obj.ability);
                    }

                    #endregion

                    HeroList.Add(theHero);

                    listBox1.Items.Add((Hero)theHero);
                }


            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }

            Hero MyHero = (Hero)listBox1.SelectedItem;

            lbname.Text = MyHero.ename + " " + MyHero.cname;

            lbslogan.Text = MyHero.slogan;

            pictureBox1.Image = new Bitmap(MyHero.photoFilename);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeroGroup _herogroup;

            if (rdeast.Checked)
            {
                _herogroup=HeroGroup.east;
            }
            else 
            {
                _herogroup=HeroGroup.west;
            }

            
            var query = from hero in HeroList
                        where hero.HGroup == _herogroup
                        select hero;

            listBox1.Items.Clear();
            foreach (Hero theHero in query)
            {
                listBox1.Items.Add(theHero);
            }
        }

        private void lbslogan_Click(object sender, EventArgs e)
        {

        }

        
    }
}
