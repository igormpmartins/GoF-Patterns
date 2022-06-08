using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public delegate void NotifyEvent<T>(T subject, EventArgs args);

    public class ConsoleTimer
    {
        public event NotifyEvent<ConsoleTimer> Notify;

        public void Start()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    if (Notify != null)
                        Notify(this, new EventArgs());
                    Thread.Sleep(1000);
                }
            });
            thread.Start();
        }

    }
}
