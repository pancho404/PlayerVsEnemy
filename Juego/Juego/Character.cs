using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Juego
{
    abstract class Character
    {
        private string Symbol;
        private int posY = 0;
        private int posX = 0;

        public Character(string Symbol, int PosY, int PosX)
        {
            this.Symbol = Symbol;
            this.posY = PosY;
            this.posX = PosX;
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public void DrawCharacter()
        {
            Console.Clear();
            Console.SetCursorPosition(PosX, PosY);
            Console.Write(Symbol);
            Thread.Sleep(10);
        }

        public abstract void MoveCharacter();
    }
}
