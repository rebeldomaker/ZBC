using System;
using System.Collections.Generic;
using System.Globalization;

namespace Repetitionsopgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Vælg en mulighed:");
                Console.WriteLine("1) Beregn gennemsnit manuelt");
                Console.WriteLine("2) Beregn gennemsnit fra fil (ekstra)");
                Console.WriteLine("3) Afslut");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateAverageManual();
                        break;
                    case "2":
                        CalculateAverageFromFile();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        break;
                }

                Console.WriteLine("Vil du beregne gennemsnit af en ny række tal? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }

        static void CalculateAverageManual()
        {
            List<double> numbers = new List<double>();
            Console.WriteLine("Indtast værdier (skriv 'q' for at afslutte):");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    break;
                }

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    numbers.Add(value);
                }
                else
                {
                    Console.WriteLine("Ugyldigt input. Prøv igen.");
                }
            }

            if (numbers.Count > 0)
            {
                double sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                double average = sum / numbers.Count;
                Console.WriteLine($"Gennemsnittet er: {average}");
            }
            else
            {
                Console.WriteLine("Ingen værdier blev indtastet.");
            }
        }

        static void CalculateAverageFromFile()
        {
            Console.WriteLine("Indtast navnet på filen (inkl. udvidelse):");
            string fileName = Console.ReadLine();

            try
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);
                List<double> numbers = new List<double>();

                foreach (var line in lines)
                {
                    if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                    {
                        numbers.Add(value);
                    }
                    else
                    {
                        Console.WriteLine($"Ugyldig værdi i filen: {line}");
                    }
                }

                if (numbers.Count > 0)
                {
                    double sum = 0;
                    foreach (var num in numbers)
                    {
                        sum += num;
                    }
                    double average = sum / numbers.Count;
                    Console.WriteLine($"Gennemsnittet er: {average}");
                }
                else
                {
                    Console.WriteLine("Ingen gyldige værdier blev fundet i filen.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Kunne ikke læse filen: {ex.Message}");
            }
        }
    }
}
