using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Railroad: Field
    {
        public override int work(Player player)
        {
            if (owner.id == 0)
            {
                return 1; //Game will send a question to player if it wants to buy it
            }
            else if (this.owner.id == player.id)
            {
                return 0; //Game will send question to player if he wants to build houses
            }
            else
            {
                // 5; 15; 25; 35 railroad fields
                int temp = 0;
                if (Array.IndexOf(this.owner.property, 5) > -1)
                    temp += 1;
                if (Array.IndexOf(this.owner.property, 15) > -1)
                    temp += 1;
                if (Array.IndexOf(this.owner.property, 25) > -1)
                    temp += 1;
                if (Array.IndexOf(this.owner.property, 35) > -1)
                    temp += 1;


                player.changeMoney(-1 * this.values[temp + 2]);
                owner.changeMoney(this.values[temp + 2]);
                if (player.money < 0)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
