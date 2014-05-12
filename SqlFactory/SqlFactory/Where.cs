using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class Where
    {
        private string _sql;
        private List<ICondition> _conditions;

        public Where(string initialSql, ICondition condition)
        {
            _sql = initialSql;
            _conditions = new List<ICondition> { condition };
        }

        public Where And(string column, Comparison comparison, string value)
        {
            _conditions.Add(new Condition(ConditionType.AND, column, comparison, value));

            return this;
        }

        public Where Or(string column, Comparison comparison, string value)
        {
            _conditions.Add(new Condition(ConditionType.OR, column, comparison, value));

            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0} ", _sql);

            for (int i = 0; i < _conditions.Count; i++)
            {
                var condition = _conditions[i];

                if (i == 0)
                {
                    sb.AppendFormat("WHERE {0}", condition.GetCondition());
                }
                else 
                {
                    sb.AppendFormat(" {0} {1}", condition.ConditionType, condition.GetCondition());   
                }
            }

            return sb.ToString();
        }
    }
}
