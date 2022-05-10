using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class DiagonalEnemy : Enemy
    {
        Random rnd;
        private int RandomValue;
        public DiagonalEnemy(String Symbol, int PosX, int PosY, Random rnd) : base(Symbol, PosX, PosY, rnd)
        {
            this.rnd = rnd;
        }

        public void DiagonalMove()
        {
            RandomValue = rnd.Next(0, 4);
            switch (RandomValue)
            {
                case 0:
                    if (PosY > Console.WindowTop && PosX > Console.WindowLeft)
                    {
                        PosY -= 1;//arriba izquierda
                        PosX -= 1;
                    }
                    break;
                case 1:
                    if (PosY < Console.WindowHeight && PosX < Console.WindowWidth - 1)
                    {
                        PosY += 1; //abajo derecha
                        PosX += 1;
                    }
                    break;
                case 2:
                    if (PosX > Console.WindowLeft && PosY < Console.WindowHeight)
                    {
                        PosX -= 1; //abajo izquierda
                        PosY += 1;
                    }
                    break;
                case 3:
                    if (PosX < Console.WindowLeft && PosY < Console.WindowHeight)
                    {
                        PosX -= 1; //arriba derecha
                        PosY += 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
