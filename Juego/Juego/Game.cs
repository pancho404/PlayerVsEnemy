using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Game
    {

        Player player;
        Enemy enemy;

        public void Run()
        {
            while (player.Lives > 0)
            {
                Init();
                Update();
                Draw();
            }

        }
        public void Init()
        {
            player = new Player("P", 0, 0, 5, 0);
            enemy = new Enemy("E", Console.WindowWidth - 2, 0);
        }

        public void Update()
        {


            if (Console.KeyAvailable)
            {
                player.MoveCharacter();
            }
            enemy.MoveCharacter();

        }

        public void Draw()
        {
            enemy.DrawCharacter();
            player.DrawCharacter();
        }

    }
}
