using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ExactComparer : NameComparer
    {
        public override bool Compare(string name, FullName record)
        {
            var recordName = record.FirstName + " " + record.LastName;
            return name.Equals(recordName);
        }
    }
}
