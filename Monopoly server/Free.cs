using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly_server
{
    class Free: Field
    {
        public override int work(Player player)
        {
            return 0;
        }
    }
}
