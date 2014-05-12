using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SqlFactory.Tests
{
    [TestClass]
    public class SelectTests
    {
        [TestMethod]
        public void Select_returns_simple_select_with_from()
        {
            var columns = "*";
            var table = "testing";

            var expected = string.Format("SELECT {0} FROM {1}", columns, table);

            var sql = CrudFactory
                .Select(columns)
                .From(table).ToString();

            Assert.AreEqual(expected, sql);
        }

        [TestMethod]
        public void Select_returns_select_with_multiple_columns()
        {
            var columns = "id, name, person";
            var table = "testing";

            var expected = string.Format("SELECT {0} FROM {1}", columns, table);

            var sql = CrudFactory
                .Select(columns)
                .From(table).ToString();

            Assert.AreEqual(expected, sql);
        }
    }
}
