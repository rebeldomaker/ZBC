using System;

class Program
{
    static void Main(string[] args) // Added the Main method and its parameters
    {
        // equivalent to python's "print('hello world')", but note how it specifies it will be printed in the terminal/console, instead of assuming like it does in python. it is similar to how you specify TYPE of variables in C/C++
        Console.WriteLine("Hello, World!"); 
        Console.Write("input any name here: "); // i would guess "write" is different from "writeline" because write is equivalent to python's input...?

        // instead of just writing a variable's name, you specify the variable will contain a string. 
        string name = Console.ReadLine(); // after user input, the console.readline() becomes console.readline("name"), essencially 
        Console.WriteLine($"{name} is lazy. "); // user inputed a string into the NAME VARIABLE and now, this line calls the NAME variable, knows it contains a string entered by user, and shows it in the console. python's f'{string_variable} equivalent is $"{name}

        if (args.Length > 0) // if the lenght of the args is less than 0 aka jeigu lenght/ilgis yra didesnis nei 0... args means argument, i think?
        { // reminds us of javascript and css/html, don't it?
            Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
// ignore these notes below:
// See https://aka.ms/new-console-template for more information
