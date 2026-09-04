using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You wake up in a dark and damp cellar. Your flashlight has almost dead batteries, but you can see a staircase going up, and you can see 3 doors marked A, B, and C.");
            Console.WriteLine("You hear a terrible noise upstairs.");
            Console.WriteLine("What do you choose?");
            Console.WriteLine("A: Open door A");
            Console.WriteLine("B: Open door B");
            Console.WriteLine("C: Open door C");
            Console.WriteLine("T: Go up the stairs");

            string choice = Console.ReadLine();

            switch (choice.ToUpper())
            {
                case "A":
                    OpenDoorA();
                    break;
                case "B":
                    OpenDoorB();
                    break;
                case "C":
                    OpenDoorC();
                    break;
                case "T":
                    GoUpstairs();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        static void OpenDoorA()
        {
            Console.WriteLine("You open door A and find a treasure chest filled with gold.");
            // Add more logic here
        }

        static void OpenDoorB()
        {
            Console.WriteLine("You open door B and find a sleeping dragon. Better close it quietly!");
            // Add more logic here
        }

        static void OpenDoorC()
        {
            Console.WriteLine("You open door C and find a passage to the outside world.");
            // Add more logic here
        }

        static void GoUpstairs()
        {
            Console.WriteLine("You go up the stairs and find yourself in a haunted house.");
            // Add more logic here
        }
    }
}
