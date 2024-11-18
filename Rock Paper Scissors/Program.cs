using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine($"*********************************************************************************** \nWELCOME TO ROCK PAPER SCISSORS {name.ToUpper()}!\n***********************************************************************************");
            MainGame();
          

            while (true)
            {
                Console.WriteLine("Do you want to continue?");
                string input = Console.ReadLine().ToLower();
                if (input == "no")
                {
                    break;
                }
                MainGame();
            }
            Console.WriteLine("Thank you for Playing!!!");
            Console.WriteLine("***********************************************************************************");

            Console.ReadKey();
        }
        public static void MainGame()
        {
            Console.WriteLine("Rock, paper or scissors?");
            string answer = Console.ReadLine().ToLower();


            if (answer == "rock")
            {
                Random random = new Random();
                if (random.Next(0, 4) == 1)
                {
                    Console.WriteLine("I chose Paper!, YOU LOSE! ;)");
                }
                else if(random.Next(0, 4) == 2)
                {
                    Console.WriteLine("I chose Scissors!, YOU WIN! :(");
                }
                else
                {
                    Console.WriteLine("I chose Rock!, It's a draw!");
                }
            }
            else if (answer == "paper")
            {
                Random random = new Random();
                if (random.Next(0, 4) == 1)
                {
                    Console.WriteLine("I chose Paper!, It's a draw!");
                }
                else if (random.Next(0, 4) == 2)
                {
                    Console.WriteLine("I chose Scissors!, YOU LOSE! ;)");
                }
                else
                {
                    Console.WriteLine("I chose Rock!, YOU WIN! :(");
                }
            }
            else if (answer == "scissors")
            {
                Random random = new Random();
                if (random.Next(0, 4) == 1)
                {
                    Console.WriteLine("I chose Paper!, YOU WIN! :(");
                }
                else if (random.Next(0, 4) == 2)
                {
                    Console.WriteLine("I chose Scissors!,  It's a draw! :(");
                }
                else
                {
                    Console.WriteLine("I chose Rock!, YOU LOSE! ;)");
                }   
            }
            else
            {
                Console.WriteLine("Please enter a valid option!");
                MainGame();
            }
        }   
    }
}