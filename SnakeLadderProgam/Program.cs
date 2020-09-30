using System;
namespace SnakeLadderProgam
{
    class Program
    {
        static void Main(string[] args)
        {
            GameProcesser Player = new GameProcesser();
            int playerCount = Player.gameProcesser();
            Console.WriteLine("Number of times the die role to win is : " +playerCount);
        }
    }
}
