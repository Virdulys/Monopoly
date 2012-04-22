using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    public class Bank: Entity
    {
        private int id;
        private int money;
        private int[] property;

        public override void changeMoney(int value)
        {
            this.money += value;
        }
    }
}
