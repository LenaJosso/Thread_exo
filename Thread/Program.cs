
namespace Thread_exo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManualResetEvent[] events = new ManualResetEvent[64];
            StreamWriter sw = new StreamWriter("sortie.txt");
            Random générateur = new Random();
            Mutex mutex = new Mutex();
            for (int i = 0; i < 64; i++)
            {
                Work objet = new Work();
                objet.InstanceNumber = 1;
                objet.baton = mutex;
                objet.alea = générateur;
                objet.fichier = sw;
                objet.drapeau = new ManualResetEvent(false);
                events[i] = objet.drapeau;
                ThreadStart PointEntree = new ThreadStart(objet.Run);
                Thread Thread = new Thread(PointEntree);
                Thread.Start();

            }
            WaitHandle.WaitAll(events);
            sw.Close();
        }
    }
}
