using System;

namespace cSharpPractice
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
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);
        Console.WriteLine($"Wow, you are {age} years old!");


    }
}
}