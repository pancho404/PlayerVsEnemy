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
        public UI(Player player)
        {
            this.player = player;
        }

        public void DrawUI()
        {
            Console.SetCursorPosition(100, 0);
            Console.WriteLine("Lives: " + player.Lives);
            Console.SetCursorPosition(100, 1);
            Console.WriteLine("Points: " + player.Points);
            if (player.AttackMode)
            {
                Console.SetCursorPosition(100, 2);
                Console.WriteLine("Attack");
            }
        }       
    }
}
