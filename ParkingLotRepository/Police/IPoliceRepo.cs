using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository.Police
{
   public interface IPoliceRepo
    {
        Task<int> PoliceParking(ParkingModel parkingModel);
        ParkingModel PoliceUnparking(int parkingSlotNumber);
       IEnumerable<ParkingModel>  GetPoliceParkingDetail();
    }
}
