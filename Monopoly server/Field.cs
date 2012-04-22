// -----------------------------------------------------------------------
// <copyright file="field.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Monopoly_server
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    abstract class Field
    {
        public int id;
        public Bank bank;
        public Boolean buyable;
        public Boolean traded_in;
        public int[] values;
        public string name;

        public Entity owner;

        public void Initialize(Bank bank, string name, int[] values)
        {
            this.bank = bank;
            this.name = name;
            this.values = values;
        }

        public abstract int work(Player player);
        

    }
}
