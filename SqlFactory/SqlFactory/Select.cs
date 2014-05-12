using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class Select
    {
        private readonly string _sql;

        public Select(string columns) : this(columns.Replace(" ", "").Split(new [] {','}, StringSplitOptions.RemoveEmptyEntries)) { }

        public Select(string[] columns) : this(columns.ToList()) { }

        public Select(List<string> columns)
        {
            StringBuilder columnBuilder = new StringBuilder();

            columnBuilder.Append("SELECT ");
            columns.ForEach(x => columnBuilder.AppendFormat("{0}, ", x));

            var s = columnBuilder.ToString();

            var i = s.LastIndexOf(',');
            s = s.Remove(i, 2);

            _sql = s;
        }

        public From From(string table)
        {
            return new From(table, _sql);
        }

        public override string ToString()
        {
            throw new NotImplementedException("A valid sql string cannot be created from a 'Select' object alone. Please use the 'From' fluent API to complete generation of a basic SQL statement.");
        }
    }
}
