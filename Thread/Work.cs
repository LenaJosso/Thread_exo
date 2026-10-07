using System;
using System.Collections.Generic;
using System.Text;

namespace Thread_exo
{
    internal class Work
    {
        private int instanceNumber;

        public int InstanceNumber { set => instanceNumber = value; }

        public void Run()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Thread secondaire" + instanceNumber + " : " + i); 
            }
        }
    }
}
