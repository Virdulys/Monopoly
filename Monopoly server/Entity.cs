using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    abstract class Entity
    {
        public int id;
        public int money;
        public int[] property;

        public abstract void changeMoney(int value);
    }
}
