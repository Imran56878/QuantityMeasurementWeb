using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuantityMeasurementManager;
using QuantityMeasurementModel;

namespace Quantity_Measurement_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IQuantityMeasurementManager manager;

        public ValuesController(IQuantityMeasurementManager quantityMeasurementManager)
        {
            manager = quantityMeasurementManager;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInchCoverter(Feet value)
        {
            var inchValue = manager.FeetToInchConverter(value);
            if (inchValue != null)
            {
                return this.Ok(inchValue.GetValue());
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeethCoverter(Inches inch)
        {
            var feetValue = manager.InchToFeetConverter(inch);
            if (feetValue != null)
            {
                return this.Ok(feetValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("YardToFeet")]
        [HttpPost]
        public IActionResult YardToFeetConveter(Yard yard)
        {
            var feetValue = manager.YardToFeetConverter(yard);
            if (feetValue != null)
            {
                return this.Ok(feetValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("YardtoInch")]
        [HttpPost]
        public ActionResult<double> YardToInchConverter(Yard yard)
        {
            var inchValue = manager.YardToInchConverter(yard);
            if (inchValue != null)
            {
                return this.Ok(inchValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("KilogramToGram")]
        [HttpPost]
        public ActionResult<double> KilogramToGramConverter(Kilogram kilogram)
        {
            var gramValue = manager.KilogramToGramConverter(kilogram);
            if (gramValue != null)
            {
                return this.Ok(gramValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("GramToKilogram")]
        [HttpPost]
        public ActionResult<double> GramToKilogramConverter(Gram gram)
        {
            var kilogramValue = manager.GramToKilogramConverter(gram);
            if (kilogramValue != null)
            {
                return this.Ok(kilogramValue.GetValue());
            }
            return this.BadRequest();
        }
        [Route("CelsiusToFahrenheit")]
        [HttpPost]
        public ActionResult<double> CelsiusToFahrenheitConverter(Celsius celsius)
        {
            var fahrenheitValue = manager.CelsiusToFahrenheitConverter(celsius);
            if (fahrenheitValue != null)
            {
                return this.Ok(fahrenheitValue.GetValue());
            }
            return this.BadRequest();
        }

        [Route("FahrenheitToCelsius")]
        [HttpPost]
        public ActionResult<double> FahrenheittoCelsiusConverter(Fahranheit fahranheit)
        {
            var celsiusValue = manager.FahrenheitToCelsiusCoverter(fahranheit);
            if (celsiusValue != null)
            {
                return this.Ok(celsiusValue.GetValue());
            }
            return this.BadRequest();
        }
    }
}
