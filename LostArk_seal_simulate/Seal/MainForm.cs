using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        public MainForm()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            comboBox11.SelectedIndex = 0;
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            comboBox14.SelectedIndex = 0;
            comboBox15.SelectedIndex = 0;
            comboBox16.SelectedIndex = 0;
            comboBox17.SelectedIndex = 0;
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
    }
}
