using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simhwa_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            MessageBox.Show("Test");//모달
            Console.WriteLine("하세요");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            Form2 f = new Form2();
            f.Show(); //Modeless 모달 리스
            Console.WriteLine(" 하세요");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(); //Modal 모달
        }
    }
}
