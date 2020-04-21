using QuantityMeasurementRepository;
using QuantityMesurementModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuntityMeasurementManager
{
    public class ImpQuantityMeasurementManager : IQuantityMeasurementManager
    {
        private readonly IQuantityMeasurementRepository Irepo;
        public ImpQuantityMeasurementManager(IQuantityMeasurementRepository Irepo)
        {
            this.Irepo = Irepo;
        }
        /// <summary>
        /// Celsius to fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public Fahrenheit CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheit = Irepo.CelsiusToFahrenheitConverter(celsius);
            return fahrenheit;
        }
        /// <summary>
        /// Fahrenheite to celsius
        /// </summary>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public Celsius FahrenheitToCelsiusCoverter(Fahrenheit fahranheit)
        {
            var celsius = Irepo.FahrenheitToCelsiusCoverter(fahranheit);
            return celsius;
        }
        /// <summary>
        /// Feet to inch converter
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public Inches FeetToInchConverter(Feet feet)
        {
            var inch = Irepo.FeetToInchConverter(feet);
            return inch;
        }
        /// <summary>
        /// Gram to kilogram
        /// converter
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public Kilogram GramToKilogramConverter(Gram gram)
        {
            var kilogram = Irepo.GramToKilogramConverter(gram);
            return kilogram;
        }
        /// <summary>
        /// Inch to feet converter
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public Feet InchToFeetConverter(Inches inch)
        {
            var feet = Irepo.InchToFeetConverter(inch);
            return feet;
        }
        /// <summary>
        /// Kilogram to converter
        /// </summary>
        /// <param name="kilogram"></param>
        /// <returns></returns>
        public Gram KilogramToGramConverter(Kilogram kilogram)
        {
            var gram = Irepo.KilogramToGramConverter(kilogram);
            return gram;
        }
        /// <summary>
        /// Yard to feet converter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Feet YardToFeetConverter(Yard yard)
        {
            var feet = Irepo.YardToFeetConverter(yard);
            return feet;
        }
        /// <summary>
        ///      yard to inche converter
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public Inches YardToInchConverter(Yard yard)
        {
            var inch = Irepo.YardToInchConverter(yard);
            return inch;
        }
    }
}
