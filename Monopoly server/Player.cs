using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Player: Entity
    {
        public int in_jail;
        public int position = 0;
        public int last_roll = 0;

        private Random dice_value = new Random();

        public int rollDice ()
        {
            return dice_value.Next(6) + 1;
        }

        public override void changeMoney(int value)
        {
            this.money += value;
        }
    }
}
