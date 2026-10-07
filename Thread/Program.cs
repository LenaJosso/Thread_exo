
namespace Thread_exo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Work objet = new Work();
            objet.InstanceNumber = 1;
            ThreadStart PointEntree = new ThreadStart(objet.Run);
            Thread Thread = new Thread(PointEntree);
            Thread.Start();
            
        }
       
    }
}
