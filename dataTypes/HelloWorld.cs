using System;

namespace dataTypes
{
class Program


{
    static void Main(string[] args)
    {
        Console.WriteLine("Say Hello to the Program!");
        string input = Console.ReadLine();
        Console.WriteLine("Hello to you to, what is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name} nice to meet you, how old are you?");
        string age = Console.ReadLine();
        Console.WriteLine($"Wow, you are {age} years old!");


    }
}
}
