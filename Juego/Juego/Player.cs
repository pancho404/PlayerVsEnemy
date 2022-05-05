using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Player : Character
    {
        private int Lives;
        private int Points;
        public Player(string Symbol, int PosX, int PosY) : base(Symbol, PosY, PosX)
        {

        }


        public override void MoveCharacter()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.UpArrow)
            {
                PosY -= 1;
            }
            if (cki.Key == ConsoleKey.DownArrow)
            {
                PosY += 1;
            }
            if (cki.Key == ConsoleKey.RightArrow)
            {
                PosX += 1;
            }
            if (cki.Key == ConsoleKey.LeftArrow)
            {
                PosX -= 1;
            }
        }
    }

}
