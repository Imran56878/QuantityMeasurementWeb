using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Fahrenheit
    {
        double fahrenheit;
        public Fahrenheit(double _fahrenheit)
        {
            this.fahrenheit = _fahrenheit;
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
