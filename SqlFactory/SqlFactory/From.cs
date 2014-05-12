using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlFactory
{
    /// <summary>
    /// Creates the FROM section of a sql statement.
    /// </summary>
    public class From
    {
        public string Table { get; private set; }
        public Where Where { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="From"/> class.
        /// </summary>
        /// <param name="schema">The schema.</param>
        /// <param name="table">The table.</param>
        public From(string schema, string table)
        {
            Table = string.Format("{0}.{1}", schema, table);
        }

        public Where Where(string condition)
        {
            Where = new Where(condition);
            return Where;
        }

        public override string ToString()
        {
            return Table;
        }
    }
}