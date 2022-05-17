using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class RandomMovement : Movement
    {
        Random rnd;
        int posToMove;    
        public RandomMovement(Random rnd)
        {
            this.rnd = rnd;
        }

        public override void Move(ref int posX, ref int posY)
        {
            posToMove = rnd.Next(0, 4);
            switch (posToMove)
            {
                case 0:
                    if (posY > Console.WindowTop)
                    {
                        posY -= 1;
                    }
                    break;
                case 1:
                    if (posY < Console.WindowHeight)
                    {
                        posY += 1;
                    }
                    break;
                case 2:
                    if (posX > Console.WindowLeft)
                    {
                        posX -= 1;
                    }
                    break;
                case 3:
                    if (posX < Console.WindowWidth - 1)
                    {
                        posX += 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
