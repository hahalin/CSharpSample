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
    public partial class fmSetupHero : Form
    {
        public fmSetupHero()
        {
            InitializeComponent();
        }

        private void fmSetupHero_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "jpg";
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                edphoto.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            Hero h = new Hero();
            h.cname = edcname.Text;
            h.ename = edname.Text;
            h.HGroup = rdeast.Checked ? HeroGroup.east : HeroGroup.west;
            h.slogan = edslogan.Text;
            
            if (chkfly.Checked)
            {
                h.abilities.Add(HeroAbility.Fly);
            }

            if (chkiq.Checked)
            {
                h.abilities.Add(HeroAbility.IQ);
            }
            if (chkmagic.AutoCheck)
            {
                h.abilities.Add(HeroAbility.Magic);
            }
            if (chkpower.Checked)
            {
                h.abilities.Add(HeroAbility.Power);
            }

            h.photoFilename = edphoto.Text;

            listBox1.Items.Add(h);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            JArray Heros = new JArray();


            #region add hero
            foreach (Object h in listBox1.Items)
            {
                Hero theHero = (Hero)h;

                JObject jobj = new JObject();

                jobj["cname"] = theHero.cname;

                jobj["ename"] = theHero.ename;

                jobj["slogan"] = theHero.slogan;

                JArray abilityJArray = new JArray();

                var theHeroabilities = from ability in theHero.abilities select ability;

                foreach (HeroAbility ability in theHeroabilities)
                {
                    JObject tmpobj = new JObject();

                    tmpobj["ability"]  = ability.ToString();

                    abilityJArray.Add(tmpobj);
                }

                jobj["abilities"] = abilityJArray;

                if (theHero.HGroup == HeroGroup.east)
                {
                    jobj["group"] = "east";
                }
                else
                {
                    jobj["group"] = "west";
                }

                jobj["photoFilename"] = theHero.photoFilename;

                Heros.Add(jobj);
            }
            #endregion


            JObject JObjectOutput=new JObject();
            
            JObjectOutput["data"]=Heros;

            #region serilaize heros

            StringBuilder sb = new StringBuilder();

            sb.Append(JObjectOutput.ToString());
           
            using (SaveFileDialog dialog = new SaveFileDialog()) {
                if (dialog.ShowDialog(this) == DialogResult.OK) {
                    System.IO.File.WriteAllText(dialog.FileName, sb.ToString());
                }
            }

            

            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            OpenFileDialog Opendlg = new OpenFileDialog();

            if (Opendlg.ShowDialog(this) == DialogResult.OK)
            {

                string fileData= System.IO.File.ReadAllText(Opendlg.FileName);

                JArray HerosArray=((JObject) JsonConvert.DeserializeObject(fileData))["data"] as JArray;

                listBox1.Items.Clear();

                

                for (int i=0;i<  HerosArray.Count;i++)
                {
                    JObject tmpObj = (JObject)HerosArray[i];

                    var HeroData = JsonConvert.DeserializeObject<dynamic>(tmpObj.ToString());

                    #region dserilaize heros

                    Hero theHero = new Hero();

                    theHero.cname = HeroData.cname;
                    theHero.ename = HeroData.ename;
                    theHero.slogan = HeroData.slogan;
                    theHero.photoFilename= HeroData.photoFilename;
                    
                    theHero.HGroup = Enum.Parse(typeof(HeroGroup), System.Convert.ToString(HeroData.group));

                    var tmpArray= HeroData.abilities;
                    
                    foreach (var obj in tmpArray)
                    {
                        theHero.abilities.Add((HeroAbility)obj.ability);
                    }
                    
                    #endregion

                    listBox1.Items.Add((Hero)theHero);
                }

            
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            edcname.Text = "";
            edname.Text = "";
            edslogan.Text = "";
            edphoto.Text = "";
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }

            Hero theHero = (Hero)listBox1.SelectedItem;

            edcname.Text = theHero.cname;
            edname.Text = theHero.ename;
            edslogan.Text = theHero.slogan;
            edphoto.Text = theHero.photoFilename;
            rdeast.Checked = theHero.HGroup == HeroGroup.east;
            
            chkfly.Checked = theHero.abilities.IndexOf(HeroAbility.Fly) >= 0;
            chkmagic.Checked = theHero.abilities.IndexOf(HeroAbility.Magic) >= 0;
            chkpower.Checked = theHero.abilities.IndexOf(HeroAbility.Power) >= 0;
            chkiq.Checked = theHero.abilities.IndexOf(HeroAbility.IQ) >= 0;

        }
    }
}
