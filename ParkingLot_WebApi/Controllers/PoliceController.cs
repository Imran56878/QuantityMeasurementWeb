using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLotModel;
using ParkingManager.Police;

namespace ParkingLot_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliceController : ControllerBase
    {
        private readonly IPoliceManager imanager;
        public PoliceController(IPoliceManager imanager)
        {
            this.imanager = imanager;
        }
        [Route("PoliceParking")]
        [HttpPost]
        public async Task<IActionResult> PoliceParking(ParkingModel parkingModel)
        {
            var result = await this.imanager.PoliceParking(parkingModel);
            if (result == 1)
            {
                return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest();
            }
        }
        [Route("PoliceUnparking")]
        [HttpDelete]
        public ParkingModel PoliceUnparking(int parkingSlotNumber)
        {
            var result = this.imanager.PoliceUnparking(parkingSlotNumber);
            return result;
        }

        [Route("GetPoliceParkingDetail")]
        [HttpGet]
        public IEnumerable<ParkingModel> GetPoliceParkingDetail()
        {
            return this.imanager.GetPoliceParkingDetail();
        }


    }
}