﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Bank: Entity
    {
        public override void changeMoney(int value)
        {
            this.money += value;
        }
    }
}
