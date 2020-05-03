using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Police
{
   public interface IPoliceManager
    {

        Task<int> PoliceParking(ParkingModel parkingModel);
        ParkingModel PoliceUnparking(int parkingSlotNumber);
        int LastSlotNumber();
        IEnumerable<ParkingModel> GetPoliceParkingDetail();
    }
}
