using System;
namespace SnakeLadderProgam
{
    class Program
    {
        public const int WINNINGPOSITION = 100;
        public static void showResult(int player1, int player2)
        {
            if(player1 == WINNINGPOSITION)
            {
                Console.WriteLine("Player 1 is winner");
            }
            else
            {
                Console.WriteLine("Player 2 is winner");
            }
            Console.WriteLine("Final position of player 1 is " + player1);
            Console.WriteLine("Final position of player 2 is " + player2);

        }
        static void Main(string[] args)
        {
            GameProcesser Player1 = new GameProcesser();
            GameProcesser Player2 = new GameProcesser();
            while (Player1.currentPosition < WINNINGPOSITION && Player2.currentPosition < WINNINGPOSITION)
            {
                Player1.gameProcesser();
                Player2.gameProcesser();
            }
            showResult(Player1.currentPosition, Player2.currentPosition);
        }
    }
}
