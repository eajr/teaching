using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskName();
            int age = AskAge();

            GreetName("Bonjour", name);
            AgeCompare(age);
        }

        static void GreetName(string greeting, string name) {
          Console.WriteLine(greeting + " " + name);
        }
        static void AgeCompare(int age) {
          if (age >= 30) {
            Console.WriteLine("Holy shit you're old");
          }
          else if (age >= 18) {
            Console.WriteLine("You're gettin old fucker");
          }
          else {
            Console.WriteLine("Get off my lawn.");
          }
        }
        static string AskName() {
          Console.WriteLine("Whats your name?");
          return Console.ReadLine();
        }

        static int AskAge() {
          Console.WriteLine("Whats your age?");
          return Convert.ToInt32(Console.ReadLine());
        }
    }
}
