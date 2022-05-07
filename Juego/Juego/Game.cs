using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Juego
{
    class Game
    {

        Player player;
        Enemy enemy;
        UI uI;
        public void Run()
        {
            Init();
            while (player.Lives > 0)
            {
                Update();
                Draw();
            }

        }

        public void Init()
        {
            Console.CursorVisible = false;
            player = new Player("P", 0, 0, 5, 0);
            uI = new UI(player.Lives, player.Points);
            enemy = new Enemy("E", 10, 0);
        }

        public void Update()
        {

            if (Console.KeyAvailable)
            {
                player.MoveCharacter();
            }
            enemy.MoveCharacter();
            uI.Update(player);
        }

        public void Draw()
        {
            player.DrawCharacter();
            enemy.DrawCharacter();
            uI.DrawUI();
            Thread.Sleep(400);
            Console.Clear();
        }

    }
}
