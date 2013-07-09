using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// Refactored <see cref="StoreInDatabase"/> that is suitable for unit testing.
    /// </summary>
    /// <remarks>
    /// Crazy!
    /// </remarks>
    public class StoreInSqlDatabaseForTesting : StoreInDatabase
    {
        private readonly Action<IEnumerable<string>> _addAction;

        public StoreInSqlDatabaseForTesting(IDatabase database)
            : this(database, null)
        {
            _addAction = Add;
        }

        /// <summary>
        /// Ctor just to support unit testing.
        /// </summary>
        internal StoreInSqlDatabaseForTesting(IDatabase database, Action<IEnumerable<string>> addAction)
            : base(database)
        {
            _addAction = addAction;
        }

        public override void Add()
        {
            var valuesToStore = new List<string>();

            valuesToStore.AddRange(new [] { "A", "B", "C" });

            _addAction(valuesToStore);
        }
    }
}
