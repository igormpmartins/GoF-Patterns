using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Superman: Toy
    {
        public override Color GetColor() => Color.Blue;
        public override TimeSpan GetHeatingTime() => TimeSpan.FromSeconds(20);
        public override int GetPowerQuantity() => 30;
    }
}
