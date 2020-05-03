using ParkingLotModel;
using ParkingLotRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository.Police
{
    public class ImpPoliceRepo : IPoliceRepo
    {
        private readonly UserDBContext userDBContext;
        public ImpPoliceRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public IEnumerable<ParkingModel> GetPoliceParkingDetail()
        {
            var list = new List<ParkingModel>();

            var count = userDBContext.Parking.Count();
            for (int i = 1; i <= count; i++)
            {
                ParkingModel parkingModel = userDBContext.Parking.Find(i);
                if ((parkingModel != null) && parkingModel.ParkingType != "wallet")
                {
                    list.Add(userDBContext.Parking.Find(i));
                }
            }

            return list;
        }

        public int LastSlotNumber()
        {
            var a = userDBContext.Parking;
            var s = a.OrderByDescending(p => p.ParkingSlotNumber).FirstOrDefault().ParkingSlotNumber;
            return s;
        }

        public Task<int> PoliceParking(ParkingModel parkingModel)
        {
            parkingModel.TimeIn = DateTime.Now;
            parkingModel.TimeOut = DateTime.MinValue;
            var count = userDBContext.Parking.Count();
            var slotNumber = parkingModel.ParkingSlotNumber;
            for (int i = 1; i <= count+2; i++)
            {
                
                if (userDBContext.Parking.Find(slotNumber) == null)
                {
                    var result = userDBContext.Parking.Add(parkingModel);

                    break;
                }
                else  
                {
                    slotNumber = i;
                    parkingModel.ParkingSlotNumber = slotNumber;
                }

            }
            return userDBContext.SaveChangesAsync();
        }
        public ParkingModel PoliceUnparking(int parkingSlotNumber)
        {
            ParkingModel parkingModel = userDBContext.Parking.Find(parkingSlotNumber);
            if (parkingModel != null)
            {
                userDBContext.Parking.Remove(parkingModel);
                userDBContext.SaveChanges();
            }
            return parkingModel;
        }
    }
}
