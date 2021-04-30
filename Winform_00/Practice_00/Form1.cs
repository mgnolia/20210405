using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_00
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Hello Lotto");
            viewbutton.Text = "번호는 뭘까요";
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("무엇을 드셨나요?");

            Random r = new Random();
            //r.Next(1,46) => 1이상 46미만
            //MessageBox.Show(r.Next(1, 46).ToString());


            int[] rN = new int[7];
            for (int i = 0; i < rN.Length; i++)
            {
                rN[i] = r.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (rN[i] == rN[j])
                    {
                        i--;
                        break;
                    }
                }

            }

            

            // r.Next(10) //0이상이면서 10미만의 숫자 하나 출력
            number_view1.Text = rN[0].ToString();
            number_view2.Text = rN[1].ToString();
            number_view3.Text = rN[2].ToString();
            number_view4.Text = rN[3].ToString();
            number_view5.Text = rN[4].ToString();
            number_view6.Text = rN[5].ToString();
            //숫자 정렬 방법1
            //Array.Sort(rN);
            //숫자 정렬 방법2
            for (int i = 0; i < rN.Length; i++)
            {
                for (int j = 0; j < rN.Length-1; j++)
                {
                    if (rN[j]>rN[j+1])
                    {
                        int temp2 = rN[j];
                        rN[j] = rN[j + 1];
                        rN[j + 1] = temp2;
                    }
                }

            }
        }
    }
}


