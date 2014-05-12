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

        [TestMethod]
        public void Select_returns_select_with_simple_where_condition()
        {
            var columns = "id, name, person";
            var table = "testing";
            var condition = "id = 1";

            var expected = string.Format("SELECT {0} FROM {1} WHERE {2}", columns, table, condition);

            var sql = CrudFactory
                .Select(columns)
                .From(table)
                .Where("id", Comparison.Equals, "1").ToString();

            Assert.AreEqual(expected, sql);
        }

        [TestMethod]
        public void Select_returns_select_with_single_where_plus_one_and_condition()
        {
            var columns = "id, name, person";
            var table = "testing";
            var condition1 = "id = 1";
            var condition2 = "name = 'dave'";

            var expected = string.Format("SELECT {0} FROM {1} WHERE {2} AND {3}", columns, table, condition1, condition2);

            var sql = CrudFactory
                .Select(columns)
                .From(table)
                .Where("id", Comparison.Equals, "1")
                .And("name", Comparison.Equals, "'dave'")
                .ToString();

            Assert.AreEqual(expected, sql, true);
        }

        [TestMethod]
        public void Select_returns_select_with_single_where_plus_two_and_conditions()
        {
            var columns = "id, name, person";
            var table = "testing";
            var condition1 = "id = 1";
            var condition2 = "name = 'dave'";
            var condition3 = "person = 1";

            var expected = string.Format("SELECT {0} FROM {1} WHERE {2} AND {3} AND {4}", columns, table, condition1, condition2, condition3);

            var sql = CrudFactory
                .Select(columns)
                .From(table)
                .Where("id", Comparison.Equals, "1")
                .And("name", Comparison.Equals, "'dave'")
                .And("person", Comparison.Equals, "1")
                .ToString();

            Assert.AreEqual(expected, sql, true);
        }

        [TestMethod]
        public void Select_returns_select_with_single_where_with_one_or_condition()
        {
            var columns = "id, name, person";
            var table = "testing";
            var condition1 = "id = 1";
            var condition2 = "name = 'dave'";

            var expected = string.Format("SELECT {0} FROM {1} WHERE {2} OR {3}", columns, table, condition1, condition2);

            var sql = CrudFactory
                .Select(columns)
                .From(table)
                .Where("id", Comparison.Equals, "1")
                .Or("name", Comparison.Equals, "'dave'")
                .ToString();

            Assert.AreEqual(expected, sql, true);
        }

        [TestMethod]
        public void Select_returns_select_with_single_where_with_multiple_or_conditions()
        {
            var columns = "id, name, person";
            var table = "testing";
            var condition1 = "id = 1";
            var condition2 = "name = 'dave'";
            var condition3 = "person = 1";

            var expected = string.Format("SELECT {0} FROM {1} WHERE {2} OR {3} OR {4}", columns, table, condition1, condition2, condition3);

            var sql = CrudFactory
                .Select(columns)
                .From(table)
                .Where("id", Comparison.Equals, "1")
                .Or("name", Comparison.Equals, "'dave'")
                .Or("person", Comparison.Equals, "1")
                .ToString();

            Assert.AreEqual(expected, sql, true);
        }
    }
}
