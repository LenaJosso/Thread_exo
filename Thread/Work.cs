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
            Random alea = new Random();
            int back = alea.Next(1, 16);
            int fore;
            do
            {
                fore = alea.Next(1, 16);
            } while (fore == back);

            for (int i = 0; i < 100; i++)
            {
                Console.BackgroundColor = (ConsoleColor)back;
                Console.ForegroundColor = (ConsoleColor)fore;
                Console.WriteLine("Thread secondaire " + instanceNumber + " : " + i); 
            }
        }
    }
}
