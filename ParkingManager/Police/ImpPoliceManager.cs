using ParkingLotModel;
using ParkingLotRepository.Police;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Police
{
    public class ImpPoliceManager : IPoliceManager
    {
        private readonly IPoliceRepo irepo;
        public ImpPoliceManager(IPoliceRepo irepo)
        {
            this.irepo = irepo;
        }

        public IEnumerable<ParkingModel> GetPoliceParkingDetail()
        {
            return this.irepo.GetPoliceParkingDetail();
        }

        public int LastSlotNumber()
        {
            return this.irepo.LastSlotNumber();
        }

        public Task<int> PoliceParking(ParkingModel parkingModel)
        {
            return this.irepo.PoliceParking(parkingModel);
        }

        public ParkingModel PoliceUnparking(int parkingSlotNumber)
        {
            return this.PoliceUnparking(parkingSlotNumber);
        }
    }
}
