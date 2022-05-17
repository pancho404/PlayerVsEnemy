using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class LinearMovement : Movement
    {
        bool direction;

        public override void Move(ref int posX, ref int posY)
        {
            if (direction)
            {
                posX++;
                if (posX == 16)
                {
                    direction = !direction;
                }
            }
            else
            {
                posX--;
                if (posX == Console.WindowLeft)
                {
                    direction = !direction;
                }
            }
        }
    }
}
