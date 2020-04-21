using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Feet
    {
        double  feet;
        public Feet(double  feet)
        {
            this.feet = feet;
        }
     
        public double GetValue()
        {
            return this.feet;
        }
    }
}
