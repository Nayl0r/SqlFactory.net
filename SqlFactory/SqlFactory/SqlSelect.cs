using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class SqlSelect
    {
        public SqlFrom From(string table)
        {
            CrudFactory.sqlBuilder.AppendFormat(" FROM {0}", table);

            return new SqlFrom();
        }

        public override string ToString()
        {
            return CrudFactory.sqlBuilder.ToString();
        }
    }
}
