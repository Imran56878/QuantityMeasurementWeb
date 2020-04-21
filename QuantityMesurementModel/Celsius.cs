using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Celsius
    {
        double celsius;
        public Celsius(double _celsius)
        {
            this.celsius = _celsius;
        }
        /// <summary>
        /// It return the celsis value
        /// </summary>
        /// <returns></returns>
        public double GetCelsiusValue()
        {
            return this.celsius;
        }
        /// <summary>
        /// Checking the equality of Celsisu value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public bool ChechingEqualityOfCelsiusValue(Celsius celsius)
        {
            if (this.celsius == celsius.GetCelsiusValue())
                return true;
            return false;
        }
    }
}
