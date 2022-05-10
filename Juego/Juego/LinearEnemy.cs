using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class LinearEnemy : Enemy
    {
        Random rnd;
        int RandomValue;
        bool direction;
        public LinearEnemy(String symbol, int posX, int posY, Random rnd) : base(symbol, posX, posY, rnd)
        {
            this.rnd = rnd;
            RandomValue = rnd.Next(0, 2);
        }

        public void LinearMove()
        {
            if (direction)
            {
                PosX++;
                if (PosX == 16)
                {
                    direction = !direction;
                }
            }
            else
            {
                PosX--;
                if (PosX == Console.WindowLeft)
                {
                    direction = !direction;
                }
            }
        }
    }
}
