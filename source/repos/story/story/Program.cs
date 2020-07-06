using System;

namespace story
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"There was a woman name {userName}, she is {age} years old.");
            Console.WriteLine($"Her favorite food is {food} and her favorite color is {color}");
            Console.WriteLine($"{userName} love the color {color} and that is why she like to eat {food}");



        }
    }
}
