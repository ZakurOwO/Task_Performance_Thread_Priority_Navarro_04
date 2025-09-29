using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_Performance_Thread_Priority_Navarro_04
{
    internal class MyThreadClass
    {


        public static void Thread1()
        {
            for (int loopCount = 1; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(500);
            }
        }

        public static void Thread2()
        {
            for (int loopCount = 1; loopCount <= 5; loopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);
            }
        }
    }
}

