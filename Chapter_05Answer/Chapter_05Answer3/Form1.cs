﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_05Answer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> textList = new List<string>();
            textList.Add("안녕");
            textList.Add("Hello");
            textList.Add("Ahlo");
            textList.Add("곤니찌와");


            label1.Text = "";
            label1.Text = textList[new Random().Next(textList.Count)];        }
    }
}
