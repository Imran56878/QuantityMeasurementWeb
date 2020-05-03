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
    public class DeriverController : ControllerBase
    {
        private readonly IParkingManager manager;
        public DeriverController(IParkingManager manager)
        {
            this.manager = manager;
        }

        [Route("ParkingVehicle")]
        [HttpPost]
        public async Task<IActionResult> ParkingVehicle(ParkingModel parkingModel)
        {
            var result = await this.manager.ParkingVehicle(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest("Wrong Detail");
            }
        }
        [Route("UpdateParkingDetails")]
        [HttpPut]
        public async Task<IActionResult> UpdateParkingDetails(ParkingModel parkingModel)
        {
            var result = await this.manager.UpdateParkingDetails(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest( );
            }
        }


        [Route("UnparkingVehicle")]
        [HttpDelete]
        public ParkingModel UnparkingVehicle(int parkingSlotNumber)
        {
            var result = this.manager.UnparkingVehicle(parkingSlotNumber);
            return result;
        }
        [Route("ParkingCharges")]
        [HttpGet]
        public   double ParkingCharges(int parkingSlotNumber)
        {
            var result =  this.manager.ParkingCharges(parkingSlotNumber);
            return result;
        }
        [Route("GetParkingDetail")]
        [HttpGet]
        public  ParkingModel GetParkingDetail(int slotNumber)
        {
            return this.manager.GetParkingDetail(slotNumber);
        }


        [Route("GetAllParkingDetails")]
        [HttpGet]
        public IEnumerable<ParkingModel> GetAllParkingDetails()
        {
            return this.manager.GetAllParkingDetails();
        }

    }
}
