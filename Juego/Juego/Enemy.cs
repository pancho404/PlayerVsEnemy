using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Enemy : Character
    {

        Random rnd = new Random();
        private int RandomValue;
        public Enemy(String Symbol, int PosX, int PosY) : base(Symbol, PosY, PosX)
        {

        }

        public override void MoveCharacter()
        {
            RandomValue = rnd.Next(0, 3);
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
