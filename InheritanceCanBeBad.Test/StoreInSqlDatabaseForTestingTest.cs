using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceCanBeBad.Test.Stubs;

namespace InheritanceCanBeBad.Test
{
    [TestClass]
    public class StoreInSqlDatabaseForTestingTest
    {
        [TestMethod]
        public void Add_ShouldUseExpectedArray()
        {
            // Arrange
            var storeDataCalled = false;

            var databaseStub = new DatabaseStub()
            {
                StoreAction = (s) => storeDataCalled = true
            };

            List<string> expected = new List<string> { "A", "B", "C" };

            IEnumerable<string> received = null;

            Action<IEnumerable<string>> addAction = (a) => { received = a; };

            var forTesting = new StoreInSqlDatabaseForTesting(databaseStub, addAction);

            // Act
            forTesting.Add();

            // Assert
            Assert.IsFalse(storeDataCalled, "Should not call store data.");
            CollectionAssert.AreEqual(expected, received.ToList(), "Must match the expected list.");
        }
    }
}
