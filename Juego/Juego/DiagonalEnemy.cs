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
        DiagonalMovement diagonalMovement;
        public DiagonalEnemy(String Symbol, int PosX, int PosY, Random rnd) : base(Symbol, PosX, PosY, rnd)
        {
            this.rnd = rnd;
            diagonalMovement = new DiagonalMovement(rnd);
        }

        public void DiagonalMove()
        {
            int posX = PosX;
            int posY = PosY;
            diagonalMovement.Move(ref posX, ref posY);
            PosX = posX;
            PosY = posY;
        }
    }
}

