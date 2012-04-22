using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class GoJail: Field
    {
        public override int work(Player player)
        {
            player.in_jail = 3;
            player.position = 10;
            return 0;
        }
    }
}
