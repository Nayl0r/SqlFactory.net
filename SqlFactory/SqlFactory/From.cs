using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class From
    {
        private readonly string _sql;
        private string _table;

        public From(string table, string initalSql)
        {
            _table = table;
            _sql = string.Format("{0} FROM {1}", initalSql, _table);
        }

        public override string ToString()
        {
            return _sql;
        }
    }
}
