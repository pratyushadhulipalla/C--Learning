using System;
namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(1,100);
            bool win = false;

            do
            {
                Console.WriteLine("Enter a number between 1 and 100:");
                string s = Console.ReadLine();
                int i = Convert.ToInt32(s);
                if(i > winNum)
                {
                    Console.WriteLine("Too High..., Guess Low!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too Low...,Guess High!");
                }
                else if (i == winNum) 
                {
                    Console.WriteLine("You Win..!Guessed the correct number!");
                    win = true;
                }
                
                Console.WriteLine();
            
            }while(win == false);
           
            Console.WriteLine("Thank you for playing the game!!");
            
            
        }
       
     
       

        
      
        
    }
}