using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Yard
    {
        int yard;
        public Yard(int _yard)
        {
            this.yard = _yard;
        }
        public int GetYardValue()
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
