using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mangeing_Car_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WhatTime.Text = "지금은 : " + DateTime.Now.ToString("yyyy/mm/dd HH:mm:ss") + ("입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("1번 버튼 클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writeLog("2번 버튼 클릭");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeLog("3번 버튼 클릭");
        }
        private void writeLog(string contents)
        {
            //int a = 1;
            //MessageBox.Show(a.ToString("00")); //01이라고 출력됨.3자리 이상 입력하면 그대로 출력됨
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}]"+
                $"(contents)";
            //listBox1.Items.Add(logContents);

            listBox1.Items.Insert(0, logContents);
            DateManage.printLog(logContents);
        }
    }
}
