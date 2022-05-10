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
        Player playerTwo;
        public UI(Player player, Player playerTwo)
        {
            this.player = player;
            this.playerTwo = playerTwo;
        }

        public void DrawUI()
        {
            Console.SetCursorPosition(100, 0);
            Console.WriteLine("Player One Lives: " + player.Lives);
            Console.SetCursorPosition(100, 1);
            Console.WriteLine("Player One Points: " + player.Points);
            Console.SetCursorPosition(100, 3);
            Console.WriteLine("Player Two Lives: " + playerTwo.Lives);
            Console.SetCursorPosition(100, 4);
            Console.WriteLine("Player Two Points: " + playerTwo.Points);
            if (player.AttackMode)
            {
                Console.SetCursorPosition(100, 2);
                Console.WriteLine("Player One Attack");
            }
            if (playerTwo.AttackMode)
            {
                Console.SetCursorPosition(100, 5);
                Console.WriteLine("Player Two Attack");
            }
        }       
    }
}
