using ParkingLotModel;
using ParkingLotRepository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository
{
    public class ImpRepository : IRepository
    {
        private readonly UserDBContext userDBContext;
        public ImpRepository(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        public Task<int> DeriverCheckIn(ParkingModel parkingModel)
        {
            parkingModel.TimeIn = DateTime.Now;
            userDBContext.Parking.Add(parkingModel);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        public ParkingModel DeleteEntry(int parkingSlotNumber)
        {
            ParkingModel parkingModel = userDBContext.Parking.Find(parkingSlotNumber);
            if (parkingModel != null)
            {
                userDBContext.Parking.Remove(parkingModel);
                userDBContext.SaveChanges();
            }
            return parkingModel;

        }

        public Task<int> DeriverCheckOut(ParkingModel parkingModel)
        {
            var parking = userDBContext.Parking.Attach(parkingModel);
            parking.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;

        }
    }
}
