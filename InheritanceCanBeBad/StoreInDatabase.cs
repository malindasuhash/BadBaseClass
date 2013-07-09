using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// Adds some data to a data the database.
    /// </summary>
    public abstract class StoreInDatabase
    {
        private readonly IDatabase _database;

        protected StoreInDatabase(IDatabase database)
        {
            _database = database;   
        }

        /// <summary>
        /// Values to add.
        /// </summary>
        public abstract void Add();

        /// <summary>
        /// Adds the values to the database.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="comparer"></param>
        protected void Add(IEnumerable<string> values)
        {
            Console.WriteLine("Do Stuff");

            foreach (var value in values)
            {
                _database.Store(value);
            }
        }
    }
}
