using QuantityMesurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository
{
  public interface IQuantityMeasurementRepository
    {
        Inches FeetToInchConverter(Feet feet);
        Feet InchToFeetConverter(Inches inch);
        Feet YardToFeetConverter(Yard yard);
        Inches YardToInchConverter(Yard yard);
        Gram KilogramToGramConverter(Kilogram kilogram);
        Kilogram GramToKilogramConverter(Gram gram);
        Fahrenheit CelsiusToFahrenheitConverter(Celsius celsius);
        Celsius FahrenheitToCelsiusCoverter(Fahrenheit fahranheit);

    }
}
