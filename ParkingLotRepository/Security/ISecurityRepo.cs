using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository.Security
{
   public interface ISecurityRepo
    {
        Task<int> PoliceParking(ParkingModel parkingModel);
        string ParkingStatus();
    }
}
