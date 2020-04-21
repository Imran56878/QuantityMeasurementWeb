using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Yard
    {
        double yard;
        public Yard(double yard)
        {
            this.yard = yard;
        }
        public double GetYardValue()
        {
            return this.yard;
        }
        /// <summary>
        /// Checking the equality of Celsisu value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public bool ChechingEqualityOfYardValue(Yard yard)
        {
            if (this.yard == yard.GetYardValue())
            {
                return true;
            }
            return false;
        }
    }
}
