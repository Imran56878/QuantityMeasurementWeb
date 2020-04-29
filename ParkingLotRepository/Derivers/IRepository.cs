using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository
{
    public interface IRepository
    {    /// <summary>
    /// adding parking details
    /// </summary>
    /// <param name="parkingModel"></param>
    /// <returns></returns>
        Task<int> DeriverCheckIn(ParkingModel parkingModel);
        /// <summary>
        /// updating record
        /// </summary>
        /// <param name="parkingModel"></param>
        /// <returns></returns>
        Task<int> DeriverCheckOut(ParkingModel parkingModel);
        /// <summary>
        /// Deleting record
        /// </summary>
        /// <param name="parkingSlotNumber"></param>
        /// <returns></returns>
        ParkingModel DeleteEntry(int parkingSlotNumber);
    }
}
