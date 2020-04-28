using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
   public interface IParkingManager
    {
        Task<int> DeriverTimeIn(ParkingModel parkingModel);
        ParkingModel DeriverTimeOut(int parkingSlotNumber);
    }
}
