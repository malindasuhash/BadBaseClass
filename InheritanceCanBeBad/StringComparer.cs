using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceCanBeBad
{
    /// <summary>
    /// Compares two strings.
    /// </summary>
    public class SomeStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.CompareTo(y);
        }
    }
}
