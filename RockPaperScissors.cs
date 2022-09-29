using System;

namespace RockPaperScissorsByKremenaPashova
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {

            //Rock", "Paper" and "Scissors", 
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";
            Console.Write("Choose [r]ock, [p]aper, or [s]cissors: ");
            string PlayerMove = Console.ReadLine();
            if (PlayerMove == "r" || PlayerMove == "rock")
            {
                PlayerMove = Rock;
            }
            else if (PlayerMove == "p" || PlayerMove == "paper")
            {
                PlayerMove = Paper;
            }
            else if (PlayerMove == "s" || PlayerMove == "scissors")
            {
                PlayerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input . Try Again...");
            }
            Random random = new Random();
            int computerNumberRandom = random.Next(1, 4);
            string computerMove = "";
            switch (computerNumberRandom)
            {
                case 1: computerMove = Rock;
                    break;
                case 2: computerMove = Paper;
                    break;
                case 3: computerMove = Scissors;
                    break;

            }
            Console.WriteLine($"The computer chose {computerMove}.");
            if ((PlayerMove == Rock && computerMove==Scissors) || 
                PlayerMove==Paper && computerMove==Rock ||
                PlayerMove==Scissors && computerMove==Paper)
            {
                Console.WriteLine("You win.");
            }
              else if((PlayerMove==Rock && computerMove==Paper) ||
                PlayerMove==Paper && computerMove==Scissors ||
                PlayerMove==Scissors && computerMove==Rock)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("The game was draw.");
            }
                
        }
    }
}
