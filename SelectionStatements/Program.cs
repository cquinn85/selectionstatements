using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");

            Console.WriteLine("Input your guess:");
            var r = new Random();
            var number = r.Next(1, 10);
     
            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is to high!");
            }
            else if(guess < number)
            {
                Console.WriteLine("Your guess is to low!");
            }
            else
            {
                Console.WriteLine("Nevermind!");
            }
             

            
        }
    }
}
