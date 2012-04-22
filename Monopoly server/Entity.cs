using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    abstract class Entity
    {
        private int id;
        private int money;
        private int[] property;

        public abstract void changeMoney(int value);
    }
}
