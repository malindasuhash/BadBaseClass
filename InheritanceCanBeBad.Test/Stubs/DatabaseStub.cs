using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad.Test.Stubs
{
    /// <summary>
    /// Simple stub for <see cref="IDatabase"/>
    /// </summary>
    public class DatabaseStub : IDatabase
    {
        public Action<string> StoreAction { get; set; }

        public void Store(string data)
        {
            if (StoreAction != null)
            {
                StoreAction(data);
                return;
            }

            throw new NotImplementedException();
        }
    }
}
