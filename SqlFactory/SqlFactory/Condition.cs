using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public class Condition : ICondition
    {
        private readonly string _sql;

        public Condition(ConditionType type, string column, Comparison comparison, string value)
        {
            ConditionType = type;
            _sql = GenerateSql(column, comparison, value);
        }

        private string GenerateSql(string column, Comparison comparison, string value)
        {
            switch (comparison)
            {
                case Comparison.Equals:
                    return string.Format("{0} = {1}", column, value);
                case Comparison.GreaterThan:
                    return string.Format("{0} > {1}", column, value);
                case Comparison.GreaterThanEqualTo:
                    return string.Format("{0} >= {1}", column, value);
                case Comparison.LessThan:
                    return string.Format("{0} <= {1}", column, value);
                case Comparison.LessThanEqualTo:
                    return string.Format("{0} < {1}", column, value);
                case Comparison.NotEquals:
                    return string.Format("{0} != {1}", column, value);
                default: throw new Exception(string.Format("Comparison type '{0}' is not supported.", comparison));
            }
        }

        public ConditionType ConditionType { get; private set; }

        public string GetCondition()
        {
            return _sql;
        }
    }
}
