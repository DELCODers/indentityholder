using System;

namespace Day1_Exersise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to the identity taker");

            Console.WriteLine("Can you give me your name");
            string name = Console.ReadLine();

            Console.WriteLine("Can you give me your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your name of your hometown");
            string homeTown = Console.ReadLine();

            //Console.WriteLine("Your name is"")
            Console.WriteLine($"Your name is {name}. Your age is {age} Your hometown is {homeTown}");
        }
    }
}
