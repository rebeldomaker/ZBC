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
        
        Console.WriteLine($"My name is {name}, and I am {age} years old.\nDid you know that the average body temperature of a rat is {temp} celsius?\nLet's do some cool math stuff now! 2 + 2 = {x}, yeah I know, I am a math genius. Anyway...\nI am sitting next to Cassandra, she's {kammeratAlder} y/o. Both our ages combined would be {y}.\nOk I am starting to get kind of lazy from writing these cheesy wall texts so lemme speedrun some other stuff to quickly meet my quotas for my C# class today:\n{z}\nMy favorite weather is when it is between {weatherCold}-{weatherWarm}C.\nSince I was born in {year} that then means I am currently {im0ld} in {currentYear}");
        
        CheckAge();
    }
    
    // Method is defined HERE at the class level, not inside Main
    static void CheckAge()
    {
        Console.WriteLine("Input your age:\n ");
        int inputAge = int.Parse(Console.ReadLine());
        
        if (inputAge >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are underaged, access denied!");
        }
    }
}