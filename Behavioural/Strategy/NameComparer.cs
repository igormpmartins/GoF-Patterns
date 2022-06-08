using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public struct FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public abstract class NameComparer
    {
        public abstract bool Compare(string name, FullName record);
    }
}
