using ParkingLotModel;
using ParkingLotRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager
{
    public class ImpParkingManager : IParkingManager
    {
        private readonly IRepository irepo;
        public ImpParkingManager(IRepository irepo)
        {
            this.irepo = irepo;

        }
        public Task<int> DeriverCheckIn(ParkingModel parkingModel)
        {
            return this.irepo.DeriverCheckIn(parkingModel);
        }

        public ParkingModel DeleteEntry(int parkingSlotNumber)
        {
            return this.irepo.DeleteEntry(parkingSlotNumber);
        }

        public Task<int> DeriverCheckOut(ParkingModel parkingModel)
        {
            return this.irepo.DeriverCheckOut(parkingModel);
        }
    }
}
