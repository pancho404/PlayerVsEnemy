using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class PowerUp : Character
    {
        Random rnd;
        private bool active;
        public PowerUp(String Symbol, int PosX, int PosY, bool active, Random rnd) : base(Symbol, PosY, PosX)
        {
            this.active = active;
            this.rnd = rnd;
        }

        public void Move()
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
