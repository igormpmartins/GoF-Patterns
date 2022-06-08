using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strategy
{
    public class FuzzyComparer : NameComparer
    {
        public override bool Compare(string name, FullName record)
        {
            name = name.Trim();

            Regex rx = new Regex(@"[^A-Za-z\s\.\-]");
            string cleanName = rx.Replace(name, "");

            rx = new Regex(@"([\s]{2,}|[\-])");
            cleanName = rx.Replace(cleanName, " ");

            string[] names = cleanName.Split(' ');
            return names.Length == 2
                && string.Equals(names[0], record.FirstName, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(names[1], record.LastName, StringComparison.InvariantCultureIgnoreCase);

        }
    }
}
