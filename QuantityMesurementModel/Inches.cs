using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Inches
    {
        double  inch;
        public Inches(double  inch)
        {
            this.inch = inch;
        }
        public double GetValue()
        {
            return inch;
        }
    }
}
