using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Fahrenheit
    {
        double fahrenheit;
        public Fahrenheit(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }
        /// <summary>
        /// it return the fahrenheit value
        /// </summary>
        /// <returns></returns>
        public double GetFahrenheitValue()
        {
            return this.fahrenheit;
        }
    }
}
