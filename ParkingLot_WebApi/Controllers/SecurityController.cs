using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLotModel;
using ParkingLotRepository.Security;
using ParkingManager.Sucurity;

namespace ParkingLot_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityManager imanager;
        public SecurityController(ISecurityManager imanager)
        {
            this.imanager = imanager;
        }

        [Route("SecurityParking")]
        [HttpPost]
        public async Task<IActionResult> SecurityParking(ParkingModel parkingModel)
        {
            var result = await this.imanager.SecurityParking(parkingModel);
            if (result ==1)
            {
                 return this.Ok(parkingModel);
            }
            else
            {
                return this.BadRequest();
            }
        } 

        [Route("ParkingStatus")]
        [HttpGet]
        public string ParkingStatus()
        {
            return this.imanager.ParkingStatus();
        }
        [Route("GetSecurityParkingDetail")]
        [HttpGet]

        public IEnumerable<ParkingModel> GetSecurityParkingDetail()
        {
            return this.imanager.GetSecurityParkingDetail();
        }
    }
}