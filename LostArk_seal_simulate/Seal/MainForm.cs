using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seal
{
    public partial class MainForm : Form
    {
        List<TabPage> tabPages = new List<TabPage>();
        bool isCreated = false;

        List<Skill> skillList = new List<Skill>();

        public MainForm()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //comboBox9.SelectedIndex = 0;
            //comboBox10.SelectedIndex = 0;
            //comboBox11.SelectedIndex = 0;
            //sum8.SelectedIndex = 0;
            //sum17.SelectedIndex = 0;
            //sum25.SelectedIndex = 0;
            //sum6.SelectedIndex = 0;
            //sum15.SelectedIndex = 0;
            //sum23.SelectedIndex = 0; 


            for (int i = 0; i < 3; i++)
            {
                Skill skill = new Skill
                {
                    Abilitystone = new TextBox(),
                    Necklace = new TextBox(),
                    Earing1 = new TextBox(),
                    Earing2 = new TextBox(),
                    Ring1 = new TextBox(),
                    Ring2 = new TextBox(),
                    Ring2Seal = new ComboBox(),
                    Ring1Seal = new ComboBox(),
                    AllSkill = new ComboBox()

                };
                skillList.Add(skill);

                Controls.Add(skillList[i].AllSkill);
                Controls.Add(skillList[i].Abilitystone);
                Controls.Add(skillList[i].Necklace);
                Controls.Add(skillList[i].Earing1);
                Controls.Add(skillList[i].Earing2);
                Controls.Add(skillList[i].Ring1);
                Controls.Add(skillList[i].Ring1Seal);
                Controls.Add(skillList[i].Ring2);
                Controls.Add(skillList[i].Ring2Seal);

            }
            for (int i = 0; i < skillList.Count; i++)
            {
                skillList[i].AllSkill.Location = new Point(150 + i * 170, 60); 
                skillList[i].Abilitystone.Location = new Point(150 + i * 170, 100);
                skillList[i].Necklace.Location = new Point(150 + i * 170, 140);
                skillList[i].Earing1.Location = new Point(150 + i * 170, 180);
                skillList[i].Earing2.Location = new Point(150 + i * 170, 220);
                skillList[i].Ring1.Location = new Point(150 + i * 170, 260);
                skillList[i].Ring1Seal.Location = new Point(150 + i * 170, 300);
                skillList[i].Ring2.Location = new Point(150 + i * 170, 340);
                skillList[i].Ring2Seal.Location = new Point(150 + i * 170, 380);

            }

            string[] SealList = File.ReadAllLines("SealList.txt");
            for (int i = 0; i < skillList.Count; i++)
            {
                foreach (var item in SealList)
                {
                    skillList[i].AllSkill.Items.Add(item);
                }

                for (int j = 1; j <= 4; j++)
                {
                    skillList[i].Ring1Seal.Items.Add(j*3);
                    skillList[i].Ring2Seal.Items.Add(j*3);

                }
                
            }

        }
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (isCreated == false && tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
            {

                isCreated = true;
                tabPages.Add(new TabPage());
                tabControl1.TabPages.Insert(tabControl1.TabPages.Count - 1, tabPages[tabPages.Count - 1]);
                tabControl1.SelectedTab = tabPages[tabPages.Count - 1];

            }
            else
            {
                isCreated = false;        
            }
                    



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
