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
        PowerUp powerUp;
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
            Random powerUpInitialPos = new Random();
            Console.CursorVisible = false;
            powerUp = new PowerUp("O", powerUpInitialPos.Next(5, 8), powerUpInitialPos.Next(5, 8), true);
            player = new Player("P", 0, 0, 5, 0);
            uI = new UI(player);
            enemy = new Enemy("E", 10, 0);
        }

        public void Update()
        {

            if (Console.KeyAvailable)
            {
                player.MoveCharacter();
            }
            if (player.CheckCollision(enemy))
            {
                if (!player.AttackMode)
                {
                    decreasePlayerLives();
                }
                else if (player.AttackMode)
                {
                    increasePlayerPoints();
                    player.AttackMode = false;
                    powerUp.Active = true;
                }
            }
            if (player.CheckCollision(powerUp))
            {
                powerUp.MoveCharacter();
                player.EnterAttackMode();
                powerUp.Active = false;
            }
            enemy.MoveCharacter();
        }

        public void Draw()
        {
            player.DrawCharacter();
            enemy.DrawCharacter();
            if (powerUp.Active)
            {
                powerUp.DrawCharacter();
            }
            uI.DrawUI();
            Thread.Sleep(400);
            Console.Clear();
        }

        public void decreasePlayerLives()
        {
            Random rnd = new Random();
            player.Lives--;
            player.PosX = rnd.Next(0, 15);
            player.PosY = rnd.Next(0, 15);

        }
        public void increasePlayerPoints()
        {
            Random rnd = new Random();
            player.Points++;
            enemy.PosX = rnd.Next(0, 15);
            enemy.PosY = rnd.Next(0, 15);

        }
    }
}
