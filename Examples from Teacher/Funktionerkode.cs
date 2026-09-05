namespace Funktioner
{
    internal class Funktioner
    {
        static void Main(string[] args)
        {
            sayHallo();
            //sayGoodbye
            int sum = addition(3, 5);
            Console.WriteLine(sum);
            //string text = greeting("Jakob");
            //Console.WriteLine(text);
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //double sum = average(numbers);
            //Console.WriteLine(sum);
        }

        static void sayHallo()
        {
            Console.WriteLine("Hello");
        }
        static void sayGodbye()
        {
            Console.WriteLine("Goodbye");
        }
        static int addition(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }
        static string greeting(string name)
        {
            //string text = "Welcome " + name;
            string altText = $"Welcome {name}";

            return altText;
        }

        static double average(int[] array) {
            double sum = 0;
            foreach (int number in array) 
            {
                sum = sum + number;
            }
            double result = sum / array.Length;
            return result;
        }
    }
}
