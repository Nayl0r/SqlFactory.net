using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SqlFactory.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Select_returns_simple_sql()
        {
            var expected = @"SELECT * FROM table";

            var actual = CrudFactory.Select("*").From("table").ToString();

            Assert.AreEqual(expected, actual, true);
        }

        [TestMethod]
        public void Select_returns_simple_sql_with_where()
        {
            var expected = @"select * from table where id = 1";

            var actual = CrudFactory.Select("*").From("table").Where("id", "=", "1").ToString();

            Assert.AreEqual(expected, actual, true);
        }
    }
}
