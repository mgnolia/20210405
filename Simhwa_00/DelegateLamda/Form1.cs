using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();
        public Form1()
        {
            InitializeComponent();

            Button button2 = button2 = new Button();
            button2.Text = "코드로만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(100,100);
            button2.Click += Button2_Click;
            button2.Click += Button2_Click1_222;
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("Test delegate");
            };
            button2.Click +=
                (object sender, EventArgs e) => { MessageBox.Show("labda"); };
            Controls.Add(button2);

        }

        private void Button2_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click1_222(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello;
            TestDelegate b = delegate ()
            { MessageBox.Show("안녕"); };
            TestDelegate c = () => { MessageBox.Show("안녕안녕"); };

            a();
            b();
            c();
        }
        private void Hello()
        {
            MessageBox.Show("안녕안녕안녕");
        }
        private void exCallBack(TestDelegate t)
        {
            for (int i = 0; i < 3; i++)
            {
                t();
            }
        }
    }
}
