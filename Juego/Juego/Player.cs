using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Player : Character
    {
        private int lives;
        private int points;
        public Player(string Symbol, int PosX, int PosY, int Lives, int Points) : base(Symbol, PosY, PosX)
        {
            this.lives = Lives;
            this.points = Points;
        }


        public override void MoveCharacter()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.UpArrow && PosY > Console.WindowTop)
            {
                PosY -= 1;
            }
            if (cki.Key == ConsoleKey.DownArrow && PosY < Console.WindowHeight)
            {
                PosY += 1;
            }
            if (cki.Key == ConsoleKey.RightArrow && PosX < Console.WindowWidth - 1)
            {
                PosX += 1;
            }
            if (cki.Key == ConsoleKey.LeftArrow && PosX > Console.WindowLeft)
            {
                PosX -= 1;
            }
        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }

}
