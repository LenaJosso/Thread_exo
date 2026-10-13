using System;
using System.Collections.Generic;
using System.Text;

namespace Thread_exo
{
    internal class Work
    {
        private int instanceNumber;
        public int InstanceNumber { set => instanceNumber = value; }
        public Mutex baton;
        public Random alea = new Random((int)DateTime.Now.Ticks);
        public StreamWriter fichier;
        public ManualResetEvent drapeau;
        public void Run()
        {
            
            int back = alea.Next(15);
            int fore;
            do
            {
                fore = alea.Next(15);
            } while (fore == back);

            for (int i = 0; i < 100; i++)
            {
                baton.WaitOne();
                fichier.WriteLine("Objet : " + instanceNumber + " : " + i);
                
                //Console.BackgroundColor = (ConsoleColor)back;
                //Console.ForegroundColor = (ConsoleColor)fore;
                //Console.WriteLine("Thread secondaire " + instanceNumber + " : " + i); 
                baton.ReleaseMutex();
                
            }
            Thread.Sleep(50);
            drapeau.Set();

        }
    }
}
