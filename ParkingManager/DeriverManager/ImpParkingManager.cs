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
        public Task<int> ParkingVehicle(ParkingModel parkingModel)
        {
            return this.irepo.ParkingVehicle(parkingModel);
        }

        public ParkingModel UnparkingVehicle(int parkingSlotNumber)
        {
            return this.irepo.UnparkingVehicle(parkingSlotNumber);
        }

        public Task<int> UpdateParkingDetails(ParkingModel parkingModel)
        {
            return this.irepo.UpdateParkingDetails(parkingModel);
        }

        public double ParkingCharges(int slotNumber)
        {
            return this.irepo.ParkingCharges(slotNumber);
        }

        public IEnumerable<ParkingModel> GetAllParkingDetails()
        {
            return this.irepo.GetAllParkingDetails();
        }

        public ParkingModel GetParkingDetail(int slotNumber)
        {
            return this.irepo.GetParkingDetail(slotNumber);
        }
    }
}
