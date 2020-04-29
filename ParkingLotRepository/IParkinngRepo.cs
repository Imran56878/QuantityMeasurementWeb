using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotRepository
{
   public interface IParkinngRepo
    {
       Dictionary<string,List<ParkingModel>> GetAllParkingDetails();

        ParkingModel GetParkingDetail(int id);

    }
}
