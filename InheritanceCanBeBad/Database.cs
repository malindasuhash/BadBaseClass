using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// Represent a database
    /// </summary>
    public class Database : IDatabase
    {
        public void Store(string data)
        {
            Console.WriteLine("Data to store - {0}", data);
        }
    }
}
