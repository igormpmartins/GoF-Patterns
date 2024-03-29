﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Firetruck : Toy
    {
        public override Color GetColor() => Color.Red;

        public override TimeSpan GetHeatingTime() => TimeSpan.FromSeconds(10);

        public override int GetPowerQuantity() => 50;
    }
}
