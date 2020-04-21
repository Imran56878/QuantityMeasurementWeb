using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Kilogram
    {
        double  kilogram;
        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }
        public double GetKilogramValue()
        {

            return this.kilogram;
        }
        
    }
}
