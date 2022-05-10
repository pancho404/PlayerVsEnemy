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
        DiagonalEnemy diagonalEnemy;
        LinearEnemy linearEnemy;
        UI playerOneUI;
        UI playerTwoUI;
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
            playerOneUI = new UI(playerOne, 100, 0);
            playerTwoUI = new UI(playerTwo, 100, playerOneUI.PosY+playerOneUI.Offset);
            enemy = new Enemy("E", 10, 0, rnd);
            diagonalEnemy = new DiagonalEnemy("D", 10, 5, rnd);
            linearEnemy = new LinearEnemy("L", 10, 8, rnd);
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
            CheckCollisions();
            enemy.Move();
            diagonalEnemy.DiagonalMove();
            linearEnemy.LinearMove();
        }

        private void CheckCollisions()
        {
            CheckEnemyCollision(enemy, playerOne);
            CheckEnemyCollision(enemy, playerTwo);
            CheckEnemyCollision(diagonalEnemy, playerOne);
            CheckEnemyCollision(diagonalEnemy, playerTwo);
            CheckEnemyCollision(linearEnemy, playerOne);
            CheckEnemyCollision(linearEnemy, playerTwo);
            CheckPowerUpCollision(playerOne);
            CheckPowerUpCollision(playerTwo);
        }

        private void CheckPowerUpCollision(Player player)
        {
            if (player.CheckCollision(powerUp))
            {
                powerUp.Move();
                player.EnterAttackMode();
                powerUp.Active = false;
            }
        }

        private void CheckEnemyCollision(Enemy enemy, Player player)
        {
            if (player.CheckCollision(enemy))
            {
                if (!player.AttackMode)
                {
                    DecreasePlayerLives(player);
                }
                else if (player.AttackMode)
                {
                    IncreasePlayerPoints(player);
                    player.AttackMode = false;
                    powerUp.Active = true;
                }
            }
        }

        public void Draw()
        {
            playerOne.DrawCharacter();
            playerTwo.DrawCharacter();
            enemy.DrawCharacter();
            diagonalEnemy.DrawCharacter();
            linearEnemy.DrawCharacter();
            if (powerUp.Active)
            {
                powerUp.DrawCharacter();
            }
            playerOneUI.DrawUI();
            playerTwoUI.DrawUI();
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
