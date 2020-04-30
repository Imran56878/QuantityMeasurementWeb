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
            userDBContext.Parking.Add(parkingModel);
            var result = userDBContext.SaveChangesAsync();
            return result;
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

       /* public Dictionary<string, List<ParkingModel>> GetAllParkingDetails()
        {
            var walletType = new List<ParkingModel>();
            var ownerType = new List<ParkingModel>();
            var dictionary = new Dictionary<string, List<ParkingModel>>();
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
            dictionary.Add("wallet", walletType);
            dictionary.Add("owner", ownerType);
            return dictionary;
        }*/

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
