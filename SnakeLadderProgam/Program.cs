using System;
namespace SnakeLadderProgam
{
    class Program
    {
        public const int NO_CHANGE = 0;
        public const int LADDER = 1;
        public const int SNAKE_BITE = 2;
        public const int MAX_POSITION = 100;
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Random random = new Random();
            for (int count = 0; playerPosition < MAX_POSITION; count++)
            {
                int dieValue = random.Next(1, 7);
                Console.WriteLine("Player position :" + playerPosition + " and Die Rolls gives :" + dieValue);
                int check = random.Next(0, 3);
                switch (check)
                {
                    case NO_CHANGE:
                        Console.WriteLine("No Change ");
                        break;
                    case LADDER:
                        playerPosition = playerPosition + dieValue;
                        Console.WriteLine("Ladder");
                        break;
                    case SNAKE_BITE:
                        if ((playerPosition - dieValue) < 0)
                        {
                            playerPosition = 0;
                            break;
                        }
                        else
                        {
                            playerPosition = playerPosition - dieValue;
                            Console.WriteLine("Snake Bite");
                            break;
                        }
                }
                Console.WriteLine("Player position after rolling Die :" + playerPosition);
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
