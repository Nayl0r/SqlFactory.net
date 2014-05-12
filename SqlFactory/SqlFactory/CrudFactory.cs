using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlFactory
{
    public static class CrudFactory
    {
        public static Select Select(string columns)
        {
            return new Select(columns);
        }
    }
}
