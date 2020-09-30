using System;
namespace SnakeLadderProgam
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine("Player position :" + playerPosition + " and Die Rolls gives :" + dieValue);
        }
    }
}
