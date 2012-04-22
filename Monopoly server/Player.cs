using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    public class Player: Entity
    {
        private int id;
        private int money;
        private int[] property;
        private int in_jail;
        Random dice_value = new Random();

        public int rollDice ()
        {
            return dice_value.Next(11) + 2;
        }

        public override void changeMoney(int value)
        {
            this.money += value;
        }
    }
}
