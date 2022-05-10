using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Enemy : Character
    {

        Random rnd;
        private int RandomValue;
        public Enemy(String Symbol, int PosX, int PosY, Random rnd) : base(Symbol, PosY, PosX)
        {
            this.rnd = rnd;
        }

        public void Move()
        {
            RandomValue = rnd.Next(0, 4);
            switch (RandomValue)
            {
                case 0:
                    if (PosY > Console.WindowTop)
                    {
                        PosY -= 1;
                    }
                    break;
                case 1:
                    if (PosY < Console.WindowHeight)
                    {
                        PosY += 1;
                    }
                    break;
                case 2:
                    if (PosX > Console.WindowLeft)
                    {
                        PosX -= 1;
                    }
                    break;
                case 3:
                    if (PosX < Console.WindowWidth - 1)
                    {
                        PosX += 1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
