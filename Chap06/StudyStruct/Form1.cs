using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyStruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Account(100, textBox1, Text);
            MessageBox.Show(a1.name+a1.myMoney);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.mymoney = 1234;
            MessageBox.Show(a1.name + a1.mymoney);
            MessageBox.Show(a2.name + a2.mymoney);
        }
    }
}
