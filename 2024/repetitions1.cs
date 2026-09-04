using System;

namespace Repetitionsopgave
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Vurdering af tal");
                Console.WriteLine("2) Udskriv liste af lige tal");
                Console.WriteLine("3) Alder");
                Console.WriteLine("4) Afslut");
                Console.Write("Vælg en mulighed: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EvaluateNumbers();
                        break;
                    case "2":
                        PrintEvenNumbers();
                        break;
                    case "3":
                        CalculateAge();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }
            }
        }

        static void EvaluateNumbers()
        {
            Console.WriteLine("Indtast 4 heltal:");
            int[] numbers = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Tal {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int evenCount = 0;
            int oddCount = 0;
            int greaterThan100Count = 0;
            int negativeCount = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

                if (num > 100)
                    greaterThan100Count++;

                if (num < 0)
                    negativeCount++;
            }

            Console.WriteLine($"Antal lige tal: {evenCount}");
            Console.WriteLine($"Antal ulige tal: {oddCount}");
            Console.WriteLine($"Antal tal større end 100: {greaterThan100Count}");
            Console.WriteLine($"Antal negative tal: {negativeCount}");
        }

        static void PrintEvenNumbers()
        {
            Console.WriteLine("Indtast to heltal:");
            Console.Write("Første tal: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Andet tal: ");
            int num2 = int.Parse(Console.ReadLine());

            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);

            Console.WriteLine("Lige tal mellem de to tal:");
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            int divisionCount = max / min;
            Console.WriteLine($"Det mindste tal går op i det største {divisionCount} gange.");
        }

        static void CalculateAge()
        {
            Console.WriteLine("Indtast din fødselsdato:");
            Console.Write("År: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Måned: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Dag: ");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthDate.Year;
            if (currentDate < birthDate.AddYears(age))
                age--;

            Console.WriteLine($"Din alder er: {age} år.");
        }
    }
}
