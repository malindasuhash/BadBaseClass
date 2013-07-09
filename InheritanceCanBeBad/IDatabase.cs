using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// Encapsulates the database.
    /// </summary>
    public interface IDatabase
    {
        void Store(string data);
    }
}
