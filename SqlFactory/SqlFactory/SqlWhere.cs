using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class SqlWhere
    {
        public SqlWhere And(string column, string @operator, string value)
        {
            CrudFactory.sqlBuilder.AppendFormat(" AND {0} {1} {2}", column, @operator, value);

            return new SqlWhere();
        }

        public SqlWhere Or(string column, string @operator, string value)
        {
            CrudFactory.sqlBuilder.AppendFormat(" OR {0} {1} {2}", column, @operator, value);

            return new SqlWhere();
        }

        public override string ToString()
        {
            return CrudFactory.sqlBuilder.ToString();
        }
    }
}
