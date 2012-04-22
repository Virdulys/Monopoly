using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Jail: Field
    {
        public override int work (Player player)
        {
            int dice1 = player.rollDice();
            int dice2 = player.rollDice();

            if (dice1 == dice2)
            {
                player.in_jail = 0;
            }
            else
            {
                player.in_jail -= 1;
            }

            return 0;
        }
    }
}
