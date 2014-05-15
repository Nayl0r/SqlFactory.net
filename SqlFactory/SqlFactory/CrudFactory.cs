using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlFactory
{
    public static class CrudFactory
    {
        internal static StringBuilder sqlBuilder = new StringBuilder();

        public static SqlSelect Select(string columns)
        {
            sqlBuilder.Clear();

            sqlBuilder.AppendFormat("SELECT {0}", columns);

            return new SqlSelect();
        }
    }
}
