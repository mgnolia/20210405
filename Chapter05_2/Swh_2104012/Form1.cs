using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swh_2104012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "안녕하세요";
            int abc = 100;
            if (abc == 100)
                button1.Enabled = false;

            Button b = new Button();
            b.Text = "무야호";
            b.Location = new Point(50, 50);
            Controls.Add(b);

            List< int > iList = new List<int>();
            iList.Add(10);
            iList.Add(20);
            iList.Add(123);

            for (int i = 0; i < iList.Count; i++)
            {
                Console.WriteLine(iList[i]);
            }
            iList.Add(10000);
            MessageBox.Show(iList.Count+"개");

            List<string> sList = new List<string>();
            sList.Add("김가현");
            sList.Add("박지민");
            sList.Add("서정빈");
            sList.Add("양화영");
            MessageBox.Show(sList.Count + "명");
            sList.Remove("서정빈");
            string names = string.Empty;//""
            for (int i = 0; i < sList.Count; i++)
            {
                names += sList[i];
            }
            MessageBox.Show(names);

            Label l = new Label();
            l.Text = "절댓값 : " + Math.Abs(-1000);
            l.Location = new Point(100, 100);
            Controls.Add(l);


            Product p = new Product();
            p.name = "감자";
            p.price = 10000;
            Product.count++;
            MessageBox.Show("제품명 :"+p.name);
            MessageBox.Show("제품가격 :" + p.price);
            MessageBox.Show("제품개수 :" + Product.count);
            Product p2 = new Product();
            p2.name = "감자";
            p2.price = 5000;
            Product.count++;

            //선언은 함과 동시에
            Product p3 = new Product()
            { name = "파", price = 50 };

            
            Dog dj = new Dog("니니", 17);
            MessageBox.Show(dj.name + dj.age);
            Dog abcc = new Dog("꼬꼬", 0);
            MessageBox.Show("개의 수 : " + Dog.theNumberofDog);

        }   
    }
}
