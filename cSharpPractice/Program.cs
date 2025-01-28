using System;

namespace cSharpPractice
{
  class HelloWorld
  {
    public static void Run()
    {
      // Main method is no longer here, so we use a custom Run method instead
      Console.WriteLine("Say Hello to the Program!");
      string input = Console.ReadLine();
      Console.WriteLine("Hello to you too, what is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}, nice to meet you, how old are you?");
      string ageInput = Console.ReadLine();

      // Make sure input is a valid integer before parsing
      int age;
      if (int.TryParse(ageInput, out age))
      {
        Console.WriteLine($"Wow, you are {age} years old!");
      }
      else
      {
        Console.WriteLine("Oops! That doesn't seem like a valid age.");
      }
    }
  }

  class OddOrEvenNumber
  {
    public static void Run()
    {
      int evenNumber = 22;
      int oddNumber = 45;
      Console.WriteLine(evenNumber + oddNumber); // Prints 67
      Console.WriteLine(oddNumber - evenNumber); // Prints 23

    }
  }

  class dogInformation
  {
    public static void Run()
    {
      string dogName = "Archie";
      string dogBreed = "Westie";
      int dogAge = 5;
      double dogWeight = 65.22;
      bool spayed = true;
      Console.WriteLine(dogName);
      Console.WriteLine(dogBreed);
      Console.WriteLine(dogAge);
      Console.WriteLine(dogWeight);
      Console.WriteLine(spayed);
    }
  }


  class MainProgram
  {
    static void Main(string[] args)
    {
      // Choose which program to run
      Console.WriteLine("Which program do you want to run?");
      Console.WriteLine("1 - HelloWorld");
      Console.WriteLine("2 - OddOrEvenNumber");
      Console.WriteLine("3 - dogInformation");

      string choice = Console.ReadLine();

      if (choice == "1")
      {
        HelloWorld.Run();  // Calling HelloWorld's Run method
      }
      else if (choice == "2")
      {
        OddOrEvenNumber.Run();  // Calling OddOrEvenNumber's Run method
      }
      else if (choice == "3")
      {
        dogInformation.Run();  // Calling dogInformation's Run method
      }
      else
      {
        Console.WriteLine("Invalid choice.");
      }
    }
  }
}
