using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{

    class DiagonalMovement : Movement
    {
        Random rnd;
        int posToMove;

        public DiagonalMovement(Random rnd)
        {
            this.rnd = rnd;
        }

        public override void Move(ref int posX, ref int posY)
        {
            posToMove = rnd.Next(0, 4);
            switch (posToMove)
            {
                case 0:
                    if (posY > Console.WindowTop && posX > Console.WindowLeft)
                    {
                        posY -= 1;//arriba izquierda
                        posX -= 1;
                    }
                    break;
                case 1:
                    if (posY < Console.WindowHeight && posX < Console.WindowWidth - 1)
                    {
                        posY += 1; //abajo derecha
                        posX += 1;
                    }
                    break;
                case 2:
                    if (posX > Console.WindowLeft && posY < Console.WindowHeight)
                    {
                        posX -= 1; //abajo izquierda
                        posY += 1;
                    }
                    break;
                case 3:
                    if (posX < Console.WindowLeft && posY < Console.WindowHeight)
                    {
                        posX -= 1; //arriba derecha
                        posY += 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
