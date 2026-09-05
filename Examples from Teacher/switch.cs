/* Console.WriteLine("Choose your Neopet: ");
Console.WriteLine("1. Gelert");
Console.WriteLine("2. Acara");
Console.WriteLine("3. Aisha"); */

Console.WriteLine("Check your OC's bio: ");
Console.WriteLine("1. Species");
Console.WriteLine("2. Age");
Console.WriteLine("3. Done.");
Console.WriteLine("Choose an option (1-3):");

string x = Console.ReadLine();

switch (x)
{
    case "1":
        Console.WriteLine("You have chosen SPECIES\nYour OC's species is: \nArgonian");
        break;
    case "2":
        Console.WriteLine("You have chosen AGE\nYour OC's age is: \n22");
        break;
    case "3":
        Console.WriteLine("Exiting program...");
        break;
    default:
        Console.WriteLine("Invalid user input. Please try again.");
        break;
}
Console.WriteLine("Program exited.");

