using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Police
{
   public interface IPoliceManager
    {
         /// <summary>
         /// It will add the police parking Details
         /// </summary>
         /// <param name="parkingModel"></param>
         /// <returns></returns>
        Task<int> PoliceParking(ParkingModel parkingModel);
        /// <summary>
        /// It will Unpark the vehicle.
        /// </summary>
        /// <param name="parkingSlotNumber"></param>
        /// <returns></returns>
        ParkingModel PoliceUnparking(int parkingSlotNumber);
        /// <summary>
        /// It will show the all
        /// wallet parking type Details
        /// </summary>
        /// <returns></returns>
        IEnumerable<ParkingModel> GetPoliceParkingDetail();
    }
}
