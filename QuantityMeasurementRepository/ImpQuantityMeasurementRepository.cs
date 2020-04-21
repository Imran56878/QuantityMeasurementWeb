using QuantityMesurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurementRepository
{
    public class ImpQuantityMeasurementRepository : IQuantityMeasurementRepository
    {
        /// <summary>
        /// It convert the Celsius 
        /// to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public Fahrenheit CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = (celsius.GetCelsiusValue() + 32) * 9 / 5;
            Fahrenheit fahranheit = new Fahrenheit(fahrenheitValue);
            return fahranheit;

        }
        /// <summary>
        /// It convert the Fahrenheit
        /// to Celsius 
        /// </summary>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public Celsius FahrenheitToCelsiusCoverter(Fahrenheit fahranheit)
        {
            var celsiusValue = (fahranheit.GetFahrenheitValue() - 32) * 5 / 9;
            Celsius celsius = new Celsius(celsiusValue);
            return celsius;

        }
        /// <summary>
        /// It convert the Feet value 
        /// to Inches
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var feetToInchValue = feet.GetFeetValue() * 12;
            Inches inchValue = new Inches(feetToInchValue);
            return inchValue;
        }
        /// <summary>
        /// This is useed for conversion from 
        /// gram to Kilogram
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public Kilogram GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = gram.GetGramValue() / 1000;
            Kilogram kilogram = new Kilogram(kilogramValue);
            return kilogram;
        }
        /// <summary>
        /// This is used for conversion of Inch to Feet
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public Feet InchToFeetConverter(Inches inch)
        {
            var inchValue = inch.getInches() / 12;
            Feet feet = new Feet(inchValue);
            return feet;
        }
        /// <summary>
        /// This is for conversion of 
        /// Kilogram to Gram
        /// </summary>
        /// <param name="kilogram"></param>
        /// <returns></returns>
        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = kilogram.GetKilogramValue() * 1000;
            Gram gram = new Gram(gramValue);
            return gram;

        }
        /// <summary>
        /// Thios for Yard to Feet
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Feet YardToFeetConverter(Yard yard)
        {
            var yardToFeet = yard.GetYardValue() * 3;
            var feetValue = new Feet(yardToFeet);
            return feetValue;
        }
        /// <summary>
        /// This one for Yard to inches conversion
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Inches YardToInchConverter(Yard yard)
        {
            var inchValue = yard.GetYardValue() * 36;
            Inches inches = new Inches(inchValue);
            return inches;
        }
    }
}
