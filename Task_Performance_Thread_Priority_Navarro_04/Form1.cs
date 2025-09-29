﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task_Performance_Thread_Priority_Navarro_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";


            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();


            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            ThreadStatus.Text = "- End of Threads -";
            

        }
    }
}
