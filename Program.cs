﻿// See https://aka.ms/new-console-template for more information

namespace practice
{
  class program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");

      Console.WriteLine("What is your name?");
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      Console.WriteLine($"{Environment.NewLine}Hi, {name}, on {currentDate:d} at {currentDate:t}!");
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }
  }
}
