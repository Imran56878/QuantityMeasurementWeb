using Microsoft.EntityFrameworkCore;
using ParkingLotModel;
using ParkingLotRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotRepository  
{
   public class ImpParkingRepo   :IParkinngRepo
    {
        private readonly UserDBContext userDBContext;
        public ImpParkingRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public Dictionary<string,List<ParkingModel>> GetAllParkingDetails()
        {
 
            var walletType = new List<ParkingModel>();
            var ownerType = new List<ParkingModel>();
            var dictionary = new Dictionary<string,List<ParkingModel>>();
            var parkingDetail = userDBContext.Parking;
            var count = parkingDetail.Count();
            for (var i = 1; i <= count; i++)
            {
                ParkingModel parkingModel = userDBContext.Parking.Find(i);

                if (parkingModel.ParkingType == "wallet")
                {
                    walletType.Add(parkingModel);
                }
                else ownerType.Add(parkingModel);
            }
            dictionary.Add("wallet",walletType);
            dictionary.Add("owner", ownerType);
            return dictionary;

        }

        public ParkingModel GetParkingDetail(int id)
        {
            return userDBContext.Parking.Find(id);
        }
        
    }
}
