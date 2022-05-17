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
        RandomMovement randomMovement;
        public Enemy(String Symbol, int PosX, int PosY, Random rnd) : base(Symbol, PosY, PosX)
        {
            this.rnd = rnd;
            randomMovement = new RandomMovement(rnd);
        }

        public void Move()
        {
            int posX = PosX;
            int posY = PosY;
            randomMovement.Move(ref posX, ref posY);
            PosX = posX;
            PosY = posY;
        }
    }
}
