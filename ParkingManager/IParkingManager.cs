using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    public interface IParkingManager
    {
        Task<int> DeriverCheckIn(ParkingModel parkingModel);
        ParkingModel DeleteEntry(int parkingSlotNumber);
        Task<int> DeriverCheckOut(ParkingModel parkingModel);
        IEnumerable<ParkingModel> GetAllParkingDetails();
        ParkingModel GetParkingDetail(int id);
        double ParkingCharges(int slotNumber);
    }
}
