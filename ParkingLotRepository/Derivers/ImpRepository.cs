using ParkingLotModel;
using ParkingLotRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotRepository
{
    public class ImpRepository : IRepository
    {
        double charges = 0;
        private readonly UserDBContext userDBContext;
        public ImpRepository(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        public Task<int> ParkingVehicle(ParkingModel parkingModel)
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

        public ParkingModel UnparkingVehicle(int parkingSlotNumber)
        {
            ParkingModel parkingModel = userDBContext.Parking.Find(parkingSlotNumber);
            if (parkingModel != null)
            {
                userDBContext.Parking.Remove(parkingModel);
                userDBContext.SaveChanges();
            }
            return parkingModel;

        }

        public Task<int> UpdateParkingDetails(ParkingModel parkingModel)
        {
            var parking = userDBContext.Parking.Attach(parkingModel);
            parking.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;

        }
        public double ParkingCharges(int slotNumber)
        {

            var vehicle = userDBContext.Parking.Find(slotNumber);
            var checkIn = vehicle.TimeIn;
            var checkOut = DateTime.Now;
            if (vehicle.ParkingType == "wallet")
            {

                double hours = (checkIn - checkOut).TotalHours;
                charges = (Math.Ceiling(hours)) * (vehicle.RatePerHour);
            }

            return charges;
        }

        public ParkingModel GetParkingDetail(int slotNumber)
        {
            return userDBContext.Parking.Find(slotNumber);
        }

        public IEnumerable<ParkingModel> GetAllParkingDetails()
        {
            return userDBContext.Parking;

        }
    }
}
