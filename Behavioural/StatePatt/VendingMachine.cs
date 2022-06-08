using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatt
{
    public class VendingMachine
    {
        private State state;
        private int products = 5;

        public VendingMachine()
        {
            this.State = new NoCoin();
        }

        public int Products { get { return this.products; } set { this.products = value; } }

        public State State 
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void InsertCoin()
        {
            state.InsertCoin(this);
        }
        public void EjectCoin()
        {
            state.EjectCoin(this);
        }

        public void PushButton()
        {
            state.PushButton(this);
            state.DispenseChocolate(this);
        }

    }
}
