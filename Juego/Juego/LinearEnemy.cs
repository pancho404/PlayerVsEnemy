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
        LinearMovement linearMovement;
        public LinearEnemy(String symbol, int posX, int posY, Random rnd) : base(symbol, posX, posY, rnd)
        {
            this.rnd = rnd;
            RandomValue = rnd.Next(0, 2);
            linearMovement = new LinearMovement();
        }

        public void LinearMove()
        {
            int posX = PosX;
            int posY = PosY;
            linearMovement.Move(ref posX, ref posY);
            PosX = posX;
            PosY = posY;
                
        }
    }
}
