using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swh_ldj_210412
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_start.Text = "캐릭터뽑기";

            string sonwoohyuk = "손우혁";
            int swh_age = 20;

            Student sonwoohyuk_2 = new Student();
            sonwoohyuk_2.name = "손우혁";
            sonwoohyuk_2.age = 50;

            Class_game xenoint = new Class_game();
            xenoint.Class = "티치엘";
            xenoint.level = 90;
            xenoint.id = "xenoint";
            Class_game.Count++;


            Class_game 천지천륜 = new Class_game();
            천지천륜.Class = "시벨린";
            천지천륜.level = 223;
            천지천륜.id = "천지천륜[단]";
            Class_game.Count++;


            Class_game 흑향월진 = new Class_game();
            흑향월진.Class = "보리스";
            흑향월진.level = 150;
            흑향월진.id = "흑향월진";
            Class_game.Count++;

            Class_game Royal = new Class_game() { Class = "밀라", level = 200, id = "Royal!" };

            Button b = new Button();
            b.Text = xenoint.Class;
            b.Location = new Point(300,300);
            Controls.Add(b);

            List<int> testList = new List<int>();
            testList.Add(1);
            string n = "" + testList.Count + ",";

            //Queue<int> t = new Queue<int>();
            //Stack<int> tt = new Stack<int>();

            testList.Add(5);
            n += "" + testList.Count;
            Console.WriteLine(n);
            int[] testArray = new int[10];
            testArray[0] = 100;
            Console.WriteLine(testArray.Length);
            //testArray = new int[100];

            //ArrayList a = new ArrayList();
            //a.Add(123);
            //a.Add("asads");
            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);

            string[] testStringArray = new string[10];
            List<string> testStringList = new List<string>();

            Class_game[] testStringArray2 = new Class_game[10];
            List<Class_game> gameUserList = new List<Class_game>();

            Dog dj = new Dog("멍멍이", 300);
            Console.WriteLine(dj.name + "," + dj.age + "," + Dog.count);
            Dog dj2 = new Dog("냥냥이", 3);
            Console.WriteLine(dj2.name + "," + dj2.age + "," + Dog.count);


            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", age = 10, grade = 1 });
            
            Student s = new Student() { name = "동준이", age = 20, grade = 2 };
            students.Add(s);

            students.Add(new Student() { name = "김동준", age = 30, grade = 3 });
            students.Add(new Student() { name = "최동준", age = 40, grade = 4 });
            students.Add(new Student() { name = "박동준", age = 50, grade = 1 });

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].name}학생 {students[i].grade}학년";
                label.AutoSize = true;
                label.Location = new Point(13, 13 + (26 * i));
                Controls.Add(label);

            }

            for (int i = students.Count-1; i >= 0; i--)
            {
                if (students[i].grade > 1)
                    students.RemoveAt(i);
            }

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].name}학생 {students[i].grade}학년";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + (26 * i));
                Controls.Add(label);

            }
        }




    }
}
