using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConsoleClock
    {
        public void Update(ConsoleTimer sender, EventArgs args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
