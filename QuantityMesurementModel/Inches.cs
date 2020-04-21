using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Inches
    {
        int inch;
        public Inches(int _inch)
        {
            this.inch = _inch;
        }
        public bool ConvertedInchValue(Inches _inch)
        {
            if (this.inch.Equals(_inch.inch))
                return true;
            return false;
        }
        public int getInches()
        {
            return inch;
        }
    }
}
