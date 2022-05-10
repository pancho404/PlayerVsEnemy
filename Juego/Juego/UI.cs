using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class UI
    {
        Player player;
        int posX;
        int posY;
        int offset;
        public UI(Player player, int posX, int posY)
        {
            this.player = player;
            this.posX = posX;
            this.posY = posY;
            offset = 3;
        }

        public void DrawUI()
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("Player Lives: " + player.Lives);
            Console.SetCursorPosition(posX, posY+1);
            Console.WriteLine("Player Points: " + player.Points);
         
            if (player.AttackMode)
            {
                Console.SetCursorPosition(posX, posY+2);
                Console.WriteLine("Attack");
            }
            
        }       

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }
        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }
    }
}
