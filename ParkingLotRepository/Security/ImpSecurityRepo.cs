using ParkingLotModel;
using ParkingLotRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository.Security
{
    public class ImpSecurityRepo : ISecurityRepo
    {
        private readonly UserDBContext userDBContext;
        public ImpSecurityRepo(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }

        public string ParkingStatus()
        {
            var totalRecord = userDBContext.Parking.Count();
            var parkingDetails = userDBContext.Parking;
            var lastSlot = parkingDetails.OrderByDescending(p => p.ParkingSlotNumber).FirstOrDefault().ParkingSlotNumber;
            if (totalRecord == lastSlot)
                return "Status: Slot is Full";
            return "Status: Slot is not Full";
        }

        public Task<int> SecurityParking(ParkingModel parkingModel)
        {
            parkingModel.TimeIn = DateTime.Now;
            parkingModel.TimeOut = DateTime.MinValue;
            var count = userDBContext.Parking.Count();
            var slotNumber = parkingModel.ParkingSlotNumber;
            // var test=slotNumber>=i?slotNumber:i;
            for (int i = 1; i <= count + 2; i++)
            {

                if (userDBContext.Parking.Find(slotNumber) == null)
                {
                    CheckParkingType(parkingModel,slotNumber);
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
        public void CheckParkingType(ParkingModel parkingModel,int slotNumber)
        {
            if ((slotNumber > 75) && (slotNumber <= 100) )
            {
                parkingModel.ParkingType = "owner";
                var result = userDBContext.Parking.Add(parkingModel);
                
            }
            else
            {
                var result = userDBContext.Parking.Add(parkingModel);
                
            }

        }

        public IEnumerable<ParkingModel> GetSecurityParkingDetail()
        {
            var list = new List<ParkingModel>();

            var count = userDBContext.Parking.Count();
            for (int i = 1; i <= count; i++)
            {
                ParkingModel parkingModel = userDBContext.Parking.Find(i);
                if ((parkingModel != null) && parkingModel.ParkingType != "owner")
                {
                    list.Add(userDBContext.Parking.Find(i));
                }
            }

            return list;
        }
    }
}
