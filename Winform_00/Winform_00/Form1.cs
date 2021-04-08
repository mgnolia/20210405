using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_00
{
    public partial class Form_Test1 : Form
    {
        public Form_Test1()
        {
            InitializeComponent();
            MessageBox.Show("Hello World");
            button_test.Text = "점심먹으러 가시죠";
        }

        private void Test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("무엇을 드셨나요?");

            Random r = new Random();
            //r.Next(1,46) => 1이상 46미만
            MessageBox.Show(r.Next(1,46).ToString());
            

            // r.Next(10) //0이상이면서 10미만의 숫자 하나 출력
            label1.Text = r.Next(10).ToString();
            label2.Text = r.Next(10).ToString();
            label3.Text = r.Next(10).ToString();
            label4.Text = r.Next(10).ToString();
            label5.Text = r.Next(10).ToString();
            label6.Text = r.Next(10).ToString();

        }
    }
}
