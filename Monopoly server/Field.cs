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
    public abstract class Field
    {
        private int id;       
        private Bank bank;
        private Boolean buyable;
        private Boolean traded_in;
        private int[] values;
        private string name;

        private Entity m_owner;

        public Entity owner
        {
            get
            {
                return m_owner;
            }
            set
            {
                m_owner = value;
            }
        }

        public Field(Bank bank, string name, int[] values)
        {
            this.bank = bank;
            this.name = name;
            this.values = values;
        }

        public abstract int work(Player player);
        

    }
}
