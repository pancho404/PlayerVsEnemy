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

        Player playerOne;
        Player playerTwo;
        Enemy enemy;
        UI uI;
        PowerUp powerUp;
        Random rnd;
        public void Run()
        {
            Init();
            while (playerOne.Lives > 0)
            {
                Update();
                Draw();
            }

        }

        public void Init()
        {
            rnd = new Random();
            Console.CursorVisible = false;
            powerUp = new PowerUp("O", rnd.Next(5, 8), rnd.Next(5, 8), true, rnd);
            playerOne = new Player("P", 0, 0, 5, 0, ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.RightArrow, ConsoleKey.LeftArrow);
            playerTwo = new Player("T", 4, 4, 5, 0, ConsoleKey.W, ConsoleKey.S, ConsoleKey.D, ConsoleKey.A);
            uI = new UI(playerOne, playerTwo);
            enemy = new Enemy("E", 10, 0, rnd);
        }

        public void Update()
        {

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                playerOne.Move(cki.Key);
                playerTwo.Move(cki.Key);
            }
            if (playerOne.CheckCollision(enemy))
            {
                if (!playerOne.AttackMode)
                {
                    DecreasePlayerLives(playerOne);
                }
                else if (playerOne.AttackMode)
                {
                    IncreasePlayerPoints(playerOne);
                    playerOne.AttackMode = false;
                    powerUp.Active = true;
                }
            }
            if (playerTwo.CheckCollision(enemy))
            {
                if (!playerTwo.AttackMode)
                {
                    DecreasePlayerLives(playerTwo);
                }
                else if (playerTwo.AttackMode)
                {
                    IncreasePlayerPoints(playerTwo);
                    playerTwo.AttackMode = false;
                    powerUp.Active = true;
                }
            }
            if (playerOne.CheckCollision(powerUp))
            {
                powerUp.Move();
                playerOne.EnterAttackMode();
                powerUp.Active = false;
            }
            if (playerTwo.CheckCollision(powerUp))
            {
                powerUp.Move();
                playerTwo.EnterAttackMode();
                powerUp.Active = false;
            }
            enemy.Move();
        }

        public void Draw()
        {
            playerOne.DrawCharacter();
            playerTwo.DrawCharacter();
            enemy.DrawCharacter();
            if (powerUp.Active)
            {
                powerUp.DrawCharacter();
            }
            uI.DrawUI();
            Thread.Sleep(200);
            Console.Clear();
        }

        public void DecreasePlayerLives(Player player)
        {
            player.Lives--;
            player.PosX = rnd.Next(0, 15);
            player.PosY = rnd.Next(0, 15);

        }
        public void IncreasePlayerPoints(Player player)
        {
            player.Points++;
            enemy.PosX = rnd.Next(0, 15);
            enemy.PosY = rnd.Next(0, 15);

        }
    }
}
