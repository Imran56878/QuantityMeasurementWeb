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
            for (int i = 1; i <= count + 2; i++)
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
    }
}
