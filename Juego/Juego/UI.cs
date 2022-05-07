using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class UI
    {
        private int PlayerLives;
        private int PlayerPoints;

        public UI(int playerLives, int playerPoints)
        {
            this.PlayerLives = playerLives;
            this.PlayerPoints = playerPoints;
        }

        public void DrawUI()
        {
            Console.SetCursorPosition(100, 0);
            Console.WriteLine("Lives: " + PlayerLives);
            Console.SetCursorPosition(100, 1);
            Console.WriteLine("Points: " + PlayerPoints);
        }

        public void Update(Player player)
        {
            PlayerLives = player.Lives;
            PlayerPoints = player.Points;
        }
    }
}
