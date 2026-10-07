namespace Thread_exo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart PointEntree = new ThreadStart(NouveauThread);
            Thread Thread = new Thread(PointEntree);
            Thread.Start();
            for (int i = 0; i < 1000; i++)

            {

                
                Console.WriteLine("Thread principal" + i );
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
        static void NouveauThread()
        { 
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread secondaire" + i);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
        }
    }
}
