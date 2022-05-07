using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class PowerUp : Character
    {
        private bool active;
        public PowerUp(String Symbol, int PosX, int PosY, bool active) : base(Symbol, PosY, PosX)
        {
            this.active = active;
        }

        public override void MoveCharacter()
        {
            Random rnd = new Random();
            PosX = rnd.Next(5, 8);
            PosY = rnd.Next(5, 8);
        }

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
    }
}
