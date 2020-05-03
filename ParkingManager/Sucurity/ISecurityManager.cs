using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Sucurity
{
   public interface ISecurityManager
    {
        Task<int> SecurityParking(ParkingModel parkingModel);
        string ParkingStatus();
    }
}
