using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// This class stores the data in SQL Server database.
    /// </summary>
    public class StoreInSqlDatabase : StoreInDatabase
    {
        public StoreInSqlDatabase(IDatabase database)
            : base(database)
        {
        }

        public override void Add()
        {
            var valuesToStore = new List<string>();

            valuesToStore.AddRange(new [] { "A", "B", "C" });

            Add(valuesToStore);
        }
    }
}
