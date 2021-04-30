using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_05Answer2
{
    enum Scissor_Rock_Paper
    {
        Gawi, Bawi, Bo
    }
    enum Fruit
    {
        Banana,Kiwi,Apple=3,Strawberry
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] product = {"바나나","키위","고구마","감자","사과","딸기" };

            MessageBox.Show(product[0]);
            MessageBox.Show(product[(int)Fruit.Banana]);
            MessageBox.Show(Fruit.Banana.ToString());
            if ((Fruit)0 == Fruit.Banana)
                MessageBox.Show("숫자 0은 Bababa, Banana는 0");
            {

            }

            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myChoice = 0;//0:가위, 1: 바위, 2:보
            int pcChoice = new Random().Next(3);

            label_myresult.Text = "가위";
            if(pcChoice == 0)
            {
                label_comresult.Text = "가위";
                label_result.Text = "비김";
            }
            else if(pcChoice == 1)
            {
                label_comresult.Text = "바위";
                label_result.Text = "짐";

            }
            else
            {
                label_comresult.Text = "보";
                label_result.Text = "이김";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Scissor_Rock_Paper mychoice = Scissor_Rock_Paper.Bawi;
            Scissor_Rock_Paper pcChoice = (Scissor_Rock_Paper)new Random().Next(3);

            label_myresult.Text = mychoice.ToString();
            label_comresult.Text = pcChoice.ToString();

            if ( mychoice == pcChoice)
            {
                label_result.Text = "비김";
            }
            else if(pcChoice == Scissor_Rock_Paper.Bo)
            {
                label_result.Text = "짐";
            }
            else
            {
                label_result.Text = "이김";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] GBB = { "가위", "바위", "보" };
            Scissor_Rock_Paper mychoice =
               Scissor_Rock_Paper.Bo;
            Scissor_Rock_Paper pcChoice =
                (Scissor_Rock_Paper)new Random().Next(3);

            label_myresult.Text = GBB[(int)mychoice];
            label_comresult.Text = GBB[(int)pcChoice];

            if (mychoice == pcChoice)
            {
                label_result.Text = "비김";
            }
            else if (pcChoice == Scissor_Rock_Paper.Gawi)
            {
                label_result.Text = "짐";
            }
            else
            {
                label_result.Text = "이김";
            }

        }
    }
}
