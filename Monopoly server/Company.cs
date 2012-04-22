using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Company: Field
    {
        public override int work(Player player)
        {
            if (this.owner.id == player.id)
            {
                return 0;
            }
            else if (this.owner.id == 0)
            {
                return 1;
            }
            else
            {
                int temp = 1;
                if ((Array.IndexOf(this.owner.property, 5) > -1) && (Array.IndexOf(this.owner.property, 15) > -1))
                    temp += 1;

                if (temp == 1)
                {
                    player.changeMoney(-1 * (player.last_roll * 4));
                }
                else
                {
                    player.changeMoney(-1 * (player.last_roll * 10));
                }
                return 2;
            }
        }
    }
}
