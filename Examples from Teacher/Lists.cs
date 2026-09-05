namespace Lister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            // Tilføjer elementer til listen
            names.Add("Anna");
            names.Add("Benjamin");
            names.Add("Carla");

            Console.WriteLine("Listens længede " + names.Count);
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Vi fjerner Anna fra listen");
            names.Remove("Anna");
            Console.WriteLine("Listens længede " + names.Count);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
