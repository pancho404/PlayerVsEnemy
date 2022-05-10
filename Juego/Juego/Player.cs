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
        private bool attackMode;
        ConsoleKey up;
        ConsoleKey down;
        ConsoleKey right;
        ConsoleKey left;
       

        public Player(string Symbol, int PosX, int PosY, int Lives, int Points, ConsoleKey up, ConsoleKey down, ConsoleKey right, ConsoleKey left) : base(Symbol, PosY, PosX)
        {
            this.lives = Lives;
            this.points = Points;
            this.up = up;
            this.down = down;
            this.right = right;
            this.left = left;
        }


        public void Move(ConsoleKey ck)
        {
           
            if (ck == up && PosY > Console.WindowTop)
            {
                PosY -= 1;
            }
            if (ck == down && PosY < Console.WindowHeight)
            {
                PosY += 1;
            }
            if (ck == right && PosX < Console.WindowWidth - 1)
            {
                PosX += 1;
            }
            if (ck == left && PosX > Console.WindowLeft)
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

        public bool AttackMode
        {
            get { return attackMode; }
            set { attackMode = value; }
        }
        public bool CheckCollision(Character enemy)
        {
            return (PosX == enemy.PosX && PosY == enemy.PosY);
        }

        public void EnterAttackMode()
        {
            attackMode = true;
        }
    }

}
