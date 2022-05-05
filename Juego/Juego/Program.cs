using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Player("P", 0, 0);
            while (true)
            {
                player.DrawCharacter();
                player.MoveCharacter();
            }
        }
    }
}
