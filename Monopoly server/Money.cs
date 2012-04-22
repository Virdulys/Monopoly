using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Money: Field
    {
        public override int work (Player player)
        {
            if (player.money < 0)
            {
                return -1;
            }
            else 
            {
                player.changeMoney(this.values[0]);
                return 0;
            }
        }
    }
}
