using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Gram
    {
        int gram;
        public Gram(int _gram)
        {
            this.gram = _gram;
        }
        public int GetGramValue()
        {
            return this.gram;
        }
        /// <summary>
        /// This method is checking the gram equality
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Grams(Gram gram)
        {
            if (this.gram == gram.GetGramValue())
                return true;
            return false;
        }
    }
}
