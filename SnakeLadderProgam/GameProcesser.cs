using System;
using System.Collections.Generic;
using System.Text;
namespace SnakeLadderProgam
{
    class GameProcesser
    {
        public const int NOCHANGE = 0;
        public const int LADDER = 1;
        public const int SNAKEBITE = 2;
        public const int STARTPOSITION = 0;
        public const int WINNINGPOSITION = 100;
        Random random = new Random();
        public int currentPosition = STARTPOSITION;
        public int nextPosition;
        public int dieRoll()
        {
            int dieValue = random.Next(1, 7);
            return dieValue;
        }
        public int positionChecker( int dieValue)
        {
            int check = random.Next(0, 3);
            int stepValue = 0;
            switch (check)
            {
                case NOCHANGE:
                    break;
                case LADDER:
                    stepValue = dieValue;
                    break;
                case SNAKEBITE:
                    stepValue = -dieValue;
                    break;
            }
            return stepValue;
        }
        public void gameProcesser()
        {
            int dieValue = dieRoll();
            int stepValue = positionChecker(dieValue);
            //Replay for getting Ladder
            if(stepValue > 0)
            {
                this.gameProcesser();
            }
            //check for player exceeds winning position
            if( currentPosition + stepValue > WINNINGPOSITION)
            {
                nextPosition = currentPosition;
            }
            else
            {
                nextPosition = currentPosition + stepValue;
            }
            //check for getting lower position than starting position
            if(nextPosition < STARTPOSITION )
            {
                currentPosition = STARTPOSITION;
            }
            else
            {
                 currentPosition = nextPosition;
            }
        }
    }
}
