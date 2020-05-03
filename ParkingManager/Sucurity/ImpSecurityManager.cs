using ParkingLotModel;
using ParkingLotRepository.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Sucurity
{
    public class ImpSecurityManager : ISecurityManager
    {
        private readonly ISecurityRepo irepo;
        public ImpSecurityManager(ISecurityRepo irepo)
        {
            this.irepo = irepo;
        }

        public IEnumerable<ParkingModel> GetSecurityParkingDetail()
        {
            return this.irepo.GetSecurityParkingDetail();
        }

        public string ParkingStatus()
        {
            return this.irepo.ParkingStatus();
        }

        public Task<int> SecurityParking(ParkingModel parkingModel)
        {
            return this.irepo.SecurityParking(parkingModel);
        }
    }
}
