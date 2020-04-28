using Microsoft.EntityFrameworkCore;
using ParkingLotModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotRepository.Context
{
   public class UserDBContext :DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) :base(options)
        {

        }
        public DbSet<ParkingModel > Parking
        {
            get;set;
        }

    }
}
