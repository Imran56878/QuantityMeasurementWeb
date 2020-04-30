using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    public interface IParkingManager
    {
        Task<int> ParkingVehicle(ParkingModel parkingModel);
        ParkingModel UnparkingVehicle(int parkingSlotNumber);
        Task<int> UpdateParkingDetails(ParkingModel parkingModel);
        double ParkingCharges(int slotNumber);
        IEnumerable<ParkingModel> GetAllParkingDetails();
        ParkingModel GetParkingDetail(int slotNumber);
    }
}
