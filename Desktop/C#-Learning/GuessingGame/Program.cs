// See https://aka.ms/new-console-template for more information
using System;

namespace GuessingGame
{
    class Program
    {
        public static void Main(String[] args)
        {
            string secretWord = "Pratyu";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter guess:");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outOfGuesses = true;
                }
                

            }
            if (outOfGuesses)
            {
                Console.Write("you are out of guesses, you Lose!");
            }
            else
            {
                Console.WriteLine("You Win");

            }
            
        }
    }
        
    
}
