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
                    PosY -= 1;
                    break;
                case 1:
                    PosY += 1;
                    break;
                case 2:
                    PosX -= 1;
                    break;
                case 3:
                    PosX += 1;
                    break;
                default:
                    break;
            }
        }
    }
}
