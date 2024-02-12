using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random r = new Random();

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Press any key to roll the dice");
               
                playerRandomNum = r.Next(1,7);
                Console.WriteLine("You rolled :" +  playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = r.Next(1,7);
                Console.WriteLine("enemy rolled :" + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round");

                }
                else if (enemyRandomNum > enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("Its a draw");

                }
                
                    
                

            }
        }
    }
}
    