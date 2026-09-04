using System;

namespace ComprehensiveProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1. Tasks with While Loops");
                Console.WriteLine("2. Tasks with For Loops");
                Console.WriteLine("3. Tasks with Switch");
                Console.WriteLine("4. Tasks with If-Else");
                Console.WriteLine("5. Tasks with Arrays");
                Console.WriteLine("6. Exit!!? (ノಠ益ಠ)ノ彡┻━┻");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WhileLoopTasks();
                        break;
                    case "2":
                        ForLoopTasks();
                        break;
                    case "3":
                        SwitchTasks();
                        break;
                    case "4":
                        IfElseTasks();
                        break;
                    case "5":
                        ArrayTasks();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }

        // Tasks with While Loops
        static void WhileLoopTasks()
        {
            while (true)
            {
                Console.WriteLine("Choose a while loop task:");
                Console.WriteLine("1. Calculator (with switch)");
                Console.WriteLine("2. Guess a number, Tamagotchi style!");
                Console.WriteLine("3. Return to main menu (; •_•)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculatorWithWhile();
                        break;
                    case "2":
                        GuessNumber();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
        }

        // Tasks with For Loops
        static void ForLoopTasks()
        {
            while (true)
            {
                Console.WriteLine("Choose a for loop task:");
                Console.WriteLine("1. Print all integers between 1 and n");
                Console.WriteLine("2. Print the n times table");
                Console.WriteLine("3. Print the full multiplication table");
                Console.WriteLine("4. Calculate the average of n numbers");
                Console.WriteLine("5. Return to main menu ( ㄒoㄒ)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintIntegers();
                        break;
                    case "2":
                        PrintTimesTable();
                        break;
                    case "3":
                        PrintFullMultiplicationTable();
                        break;
                    case "4":
                        CalculateAverage();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }

        // Tasks with Switch
        static void SwitchTasks()
        {
            while (true)
            {
                Console.WriteLine("Choose a switch task:");
                Console.WriteLine("1. Print day of the week");
                Console.WriteLine("2. Print number of days in a month");
                Console.WriteLine("3. Simple calculator");
                Console.WriteLine("4. Return to main menu? ( ╥ω╥ )");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintDayOfWeek();
                        break;
                    case "2":
                        PrintDaysInMonth();
                        break;
                    case "3":
                        SimpleCalculator();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }

        // Tasks with If-Else
        static void IfElseTasks()
        {
            while (true)
            {
                Console.WriteLine("Choose an if-else task:");
                Console.WriteLine("1. Find the largest number");
                Console.WriteLine("2. Check divisibility by 3 and 5");
                Console.WriteLine("3. Print number of days in a month");
                Console.WriteLine("4. Price calculator");
                Console.WriteLine("5. Return to main menu ૮( ͡° ᴥ ͡°)ა !!");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        FindLargestNumber();
                        break;
                    case "2":
                        CheckDivisibility();
                        break;
                    case "3":
                        IfElseDaysInMonth();
                        break;
                    case "4":
                        PriceCalculator();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }

        // Tasks with Arrays
        static void ArrayTasks()
        {
            while (true)
            {
                Console.WriteLine("Choose an array task:");
                Console.WriteLine("1. Basic array usage");
                Console.WriteLine("2. Print negative values in array");
                Console.WriteLine("3. Print sum of array values");
                Console.WriteLine("4. Print largest and smallest value in array");
                Console.WriteLine("5. Sort and print array values");
                Console.WriteLine("6. Combine two arrays");
                Console.WriteLine("7. Search in string array");
                Console.WriteLine("8. Return to main menu (; ˃o˂)");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BasicArrayUsage();
                        break;
                    case "2":
                        PrintNegativeValues();
                        break;
                    case "3":
                        PrintSumOfArray();
                        break;
                    case "4":
                        PrintLargestAndSmallest();
                        break;
                    case "5":
                        SortAndPrintArray();
                        break;
                    case "6":
                        CombineArrays();
                        break;
                    case "7":
                        SearchInStringArray();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }
            }
        }

        // While Loop Tasks
        static void CalculatorWithWhile()
        {
            while (true)
            {
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter operator (+, -, *, /):");
                string op = Console.ReadLine();
                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }

        static void GuessNumber()
        {
            Random rand = new Random();
            Console.WriteLine("Enter the lower bound:");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound:");
            int upper = Convert.ToInt32(Console.ReadLine());
            int target = rand.Next(lower, upper + 1);
            int attempts = 0;
            int guess = 0;

            while (guess != target)
            {
                Console.WriteLine("Guess the number:");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < target)
                {
                    Console.WriteLine("Too low! (˃ᆺ˂)");
                }
                else if (guess > target)
                {
                    Console.WriteLine("Too high!  υ´• ﻌ •`υ");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                }
            }
        }

        // For Loop Tasks
        static void PrintIntegers()
        {
            Console.WriteLine("Enter a number (n):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All integers from 1 to " + n + ":");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("All integers from " + n + " to 1:");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintTimesTable()
        {
            Console.WriteLine("Enter a number (n) for the times table:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The " + n + " times table:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i);
            }
        }

        static void PrintFullMultiplicationTable()
        {
            Console.WriteLine("The full multiplication table (1 to 10):");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static void CalculateAverage()
        {
            Console.WriteLine("How many numbers do you want to enter for the average calculation?");
            int count = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("Enter number " + i + ":");
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }

            double average = sum / count;
            Console.WriteLine("The average is: " + average);
        }

        // Switch Tasks
        static void PrintDayOfWeek()
        {
            Console.WriteLine("Enter a number (1-7) for the day of the week:");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
        }

        static void PrintDaysInMonth()
        {
            Console.WriteLine("Enter a month number (1-12):");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 days");
                    break;
                case 2:
                    Console.WriteLine("28 days");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
                    break;
            }
        }

        static void SimpleCalculator()
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operator (+, -, *, /):");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool validOperation = true;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        validOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine("Result: " + result);
            }
        }

        // If-Else Tasks
        static void FindLargestNumber()
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num3);
            }
        }

        static void CheckDivisibility()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("The number is divisible by both 3 and 5.");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3.");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 5.");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 3 or 5.");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }

        static void IfElseDaysInMonth()
        {
            Console.WriteLine("Enter a month number (1-12):");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 ||
                monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            {
                Console.WriteLine("31 days");
            }
            else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            {
                Console.WriteLine("30 days");
            }
            else if (monthNumber == 2)
            {
                Console.WriteLine("28 days");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            }
        }

        static void PriceCalculator()
        {
            Console.WriteLine("Enter electricity consumption in kWh:");
            int consumption = Convert.ToInt32(Console.ReadLine());
            double price = 0;

            if (consumption <= 1000)
            {
                price = consumption * 1.25;
            }
            else if (consumption <= 2000)
            {
                price = 1000 * 1.25 + (consumption - 1000) * 1.75;
            }
            else if (consumption <= 4000)
            {
                price = 1000 * 1.25 + 1000 * 1.75 + (consumption - 2000) * 2.10;
            }
            else
            {
                price = 1000 * 1.25 + 1000 * 1.75 + 2000 * 2.10 + (consumption - 4000) * 2.75;
            }

            price *= 1.25; // Add 25% VAT
            Console.WriteLine("Total price including VAT: " + price + " kr.");
        }

        // Array Tasks
        static void BasicArrayUsage()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The numbers you entered are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Using foreach loop:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void PrintNegativeValues()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The negative numbers you entered are:");
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void PrintSumOfArray()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum of the numbers is: " + sum);
        }

        static void PrintLargestAndSmallest()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 integers:");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = numbers[0];
            int smallest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine("The largest number is: " + largest);
            Console.WriteLine("The smallest number is: " + smallest);
        }

        static void SortAndPrintArray()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            Console.WriteLine("Enter " + size + " integers:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("The sorted array is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Extra: Print the second highest value
            if (size > 1)
            {
                Console.WriteLine("The second highest value is: " + numbers[size - 2]);
            }
        }

        static void CombineArrays()
        {
            Console.WriteLine("Enter the size of the first array:");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size1];
            Console.WriteLine("Enter " + size1 + " integers for the first array:");
            for (int i = 0; i < size1; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of the second array:");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[size2];
            Console.WriteLine("Enter " + size2 + " integers for the second array:");
            for (int i = 0; i < size2; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] combinedArray = new int[size1 + size2];
            Array.Copy(array1, combinedArray, size1);
            Array.Copy(array2, 0, combinedArray, size1, size2);

            Console.WriteLine("The combined array is:");
            foreach (int number in combinedArray)
            {
                Console.WriteLine(number);
            }
        }

        static void SearchInStringArray()
        {
            string[] texts = new string[10];
            Console.WriteLine("Enter 10 strings:");

            for (int i = 0; i < 10; i++)
            {
                texts[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter a string to search:");
            string searchString = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < texts.Length; i++)
            {
                if (texts[i] == searchString)
                {
                    Console.WriteLine($"Found '{searchString}' at position {i + 1}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"'{searchString}' not found in the array.");
            }
        }
    }
}

// Variable declaration way #1:
// Here I declare the variable of type int with the name number
// int number;
// Then I assign the variable number the value 12
// number = 12;
// Variable declaration way #2:
// Here I declare the variable of type "int" with the name number and assign it the value 12
// int number1 = 16;
// number is the name of your variable
// int number2 = 5.1;
