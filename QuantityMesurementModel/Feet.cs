using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurementModel
{
    public class Feet
    {
        int feet;
        public Feet(int _feet)
        {
            this.feet = _feet;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            return true;
        }
        public bool ConvertedFeetValue(Feet _feet)
        {
            if (this.feet.Equals(_feet.feet))
                return true;
            return false;
        }
        public int GetFeetValue()
        {
            return this.feet;
        }
    }
}
