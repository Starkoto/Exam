using System;
using System.Collections.Generic;
using System.Text;

namespace Console_game
{
    class Boss : Enemy
    {

        public Boss(): base("Orc")
        {
            Health = 200;
        }

    }
}
