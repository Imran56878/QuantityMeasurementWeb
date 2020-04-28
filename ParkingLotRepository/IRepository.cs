using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository
{
    public interface IRepository
    {
        Task<int> DeriverCheckIn(ParkingModel parkingModel);
        Task<int> DeriverCheckOut(ParkingModel parkingModel);
        ParkingModel DeriverTimeOut(int parkingSlotNumber);
    }
}
