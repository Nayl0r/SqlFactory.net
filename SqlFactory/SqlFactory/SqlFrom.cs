using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class SqlFrom
    {
        public SqlWhere Where(string column, string @operator, string value)
        {
            CrudFactory.sqlBuilder.AppendFormat(" WHERE {0} {1} {2}", column, @operator, value);

            return new SqlWhere();
        }

        public override string ToString()
        {
            return CrudFactory.sqlBuilder.ToString();
        }
    }
}
