class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        // variable slop goes here
        string name = "Jesse";
        int age = 29;
        double temp = 38.2;
        int x = 2 + 2;
        int kammeratAlder = 22;
        int y = kammeratAlder + age;
        string kammeratNavn = "Cassandra";
        string z = kammeratNavn + "&" + name + "are cool.";
        double weatherWarm = 19;
        double weatherCold = 15;
        int year = 1997;
        int currentYear = DateTime.Now.Year;
        int im0ld = currentYear - year;

        Console.WriteLine(
            $"My name is {name}, and I am {age} years old.\nDid you know that the average body temperature of a rat is {temp} celsius?\nLet's do some cool math stuff now! 2 + 2 = {x}, yeah I know, I am a math genius. Anyway...\nI am sitting next to Cassandra, she's {kammeratAlder} y/o. Both our ages combined would be {y}.\nOk I am starting to get kind of lazy from writing these cheesy wall texts so lemme speedrun some other stuff to quickly meet my quotas for my C# class today:\n{z}\nMy favorite weather is when it is between {weatherCold}-{weatherWarm}C.\nSince I was born in {year} that then means I am currently {im0ld} in {currentYear}");

        // Create a variable called erVoksen and set it to True or False depending on whether you are over 18. Print it.
        Console.WriteLine("Input your age: ");
        int inputAge = int.Parse(Console.ReadLine());
        bool isAdult = inputAge >= 18;
        Console.WriteLine(isAdult);

        // Create a program that calculates the average of three characters, e.g. 7, 10 and 4. Print the result.
        int num1 = 7;
        int num2 = 10;
        int num3 = 4;
        double numAverage = (num1 + num2 + num3) / 3.0;

        Console.WriteLine($"({num1} + {num2} + {num3}) : 3 = {numAverage}");
        // Store a city name in a variable, and print the sentence: "I live in [city name]"
        string city = "Slagelse";
        string hometown = "Kaunas";
        Console.WriteLine($"I grew up in {hometown} and now live in {city}.");
        
        string a = "Hello";
        string b = "World!";
        Console.WriteLine($"{a}, {b}");
        (a, b) = (b, a);
        Console.WriteLine($"{a} {b}");
            
        // User Input
        // Create a program where the user enters their name and the program prints the name to the console.
        Console.WriteLine("Input your Name:");
        string inputName = Console.ReadLine();
        Console.WriteLine($"Your name is {inputName}. Hello, {inputName}!");

        // Create a program that can add two numbers together and print the result
        int skaicius1 = 4;
        int skaicius2 = 20;
        int sudetis = skaicius1 + skaicius2;
        Console.WriteLine($"{skaicius1} + {skaicius2} = {sudetis}");
        
        // Ask the user their age and tell them how many years they have left until they turn 100.
        Console.WriteLine("What year were you born in?");
        int userYear = int.Parse(Console.ReadLine()); // todo parse to integer
        int userCurrentAge = currentYear - userYear; // int.Parse(userYear);
        int futureYear = userYear + 100;
        int hundredYears = 100 - userCurrentAge; // 100 - 29 = result
        
         Console.WriteLine($"It is currently {currentYear}, you were born in {userYear} making you currently {userCurrentAge} y/o. You will be 100 y/o in {futureYear}, meaning you have {hundredYears} years left until you turn 100 y/o.");
         
         // Ask the user their favorite color and print a sentence: "Your favorite color is [color] – it's beautiful!"
         Console.WriteLine("What's your favorite color? ");
         string color = Console.ReadLine();
         Console.WriteLine($"Your favorite color is {color} – it's beautiful!");
         
         // Bonus task!
         // todo Try making some console prints that guide users to what input they should give:
         // For example, "Enter your name"
         // 
         // For loop
         // todo Create a for loop that prints "Hello World!" out 5 times.
         // 
         // todo Create a for loop that prints the numbers from 0 to 10, in the console.
         // 
         // todo Create a for loop that prints the numbers from 10 to 1, in the console.
         // 
         // todo Ask the user to enter a number between 1 and 20. Count down from the user's number to 0 and display the countdown.
         // 
         // todo Create a program that prints a large X to the console using for loops.
         // 
         // todo If you have a lot of lines of code in exercise 5, try and see if you can use fewer lines.
         // 
         // todo Print the sum of the numbers from 1 to 100.
         // 
         // todo Create a program that spells a word backwards.
         // 
         // While loop
         // todo Create a while loop that prints "Hello World!" 6 times.
         // 
         // todo Make a while loop that prints the numbers from 0 to 12, in the console.
         // 
         // todo Make a program that asks the user to type "hello", every time the user does not type "hello", the program should print the user's words and ask the user to type "hello". When the user types "hello", the program stops.
         // 
         // todo Make a program that asks the user for a password. If the user types "secret", the program writes "Access granted", otherwise it asks again.
         // 
         // todo Make a program that asks the user for a number. If the number is less than 0, the program asks again. When the user enters a positive number, the program stops.
         // 
         // If-else statement
         // todo Make a program where you enter an age, and it prints:
         // "You are a teenager", if the age is between 13 and 19.
         // "You are an adult", if over 19.
         // "You are a child", if under 13
         // 
         // todo Make a program where the user enters a number. If the number is divisible by 2, say "Even number", otherwise "Odd numbers".
         // 
         // todo Make a simple quiz question: "What is the capital of Denmark?" If the answer is "Copenhagen", then print "Correct!", otherwise "Incorrect!".
         // 
         // todo Make a program that asks about the temperature (number). If it is below 0, print "It is freezing", if between 0 and 20, print "It is cold", otherwise "It is hot".
         // 
         // todo Make a program that checks whether a letter is a vowel or a consonant.
         // 
         // todo Make a program that finds the largest of 3 numbers.
         // 
         // Extra tasks
         // todo Mini-login system: The user must enter a username and password. Check if it matches the correct username and password, and grant access.
         // 
         // todo Calculator: The user selects an operation (e.g. +, -, *, /) and enters two numbers. The program displays the result.
         // 
         // todo Guess a number: The computer chooses a random number between 1 and 10. The user must guess it. The program tells you if it is too high, low or correct.
         // 
         // todo Check if a number is even or odd.
         // 
         // Array
         // todo Create an array that contains 4 of your classmates' names.
         //
         // todo Print the length of the array.
         // 
         // todo Print the third name from the array in task 1.
         // 
         // todo Print the entire array using Foreach()
         // 
         // todo Create a 2d array with {1,2,3,4} and {5,6,7,8}
         // 
         // todo Print different places from task 5
    }
}