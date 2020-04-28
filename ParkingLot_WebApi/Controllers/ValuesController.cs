using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParkingLotModel;
using ParkingManager;

namespace ParkingLot_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IParkingManager manager;
        public ValuesController(IParkingManager manager)
        {
            this.manager = manager;
        }
       
        [Route("DeriverCheckIn")]
        [HttpPost]
        public async Task<IActionResult> DeriverCheckIn(ParkingModel parkingModel)
        {
            var result = await this.manager.DeriverCheckIn(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest();
            }
        }
          [Route("DeriverCheckOut")]
         [HttpPut]
         public async Task<IActionResult> DeriverCheckOut(ParkingModel parkingModel)
         {
            var result = await this.manager.DeriverCheckOut(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest();
            }
        }
         

        [Route("DeriverCheckOut")]
        [HttpDelete]
        public ParkingModel DeleteEntry(int parkingSlotNumber)
        {
            var result = this.manager.DeleteEntry(parkingSlotNumber);
            return result;
        }
    }
}
