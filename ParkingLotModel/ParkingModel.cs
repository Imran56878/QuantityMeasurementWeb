using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingLotModel
{
    public class ParkingModel
    {
        int tokenNumber;
        string parkingStatus;
        string carColor;
        string isDriverHandicap;
        double ratePerHour;
        string vehicleNumber;
        double customerNumber;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int TokenNumber
        {
            get
            {
                return this.tokenNumber;
            }
            set
            {
                this.tokenNumber = value;
            }
        }

        public string ParkingStatus
        {
            get
            {
                return this.isDriverHandicap;
            }
            set
            {
                this.isDriverHandicap = value;
            }
        }
        public string CarColor
        {
            get
            {
                return this.carColor;
            }
            set
            {
                this.carColor = value;
            }
        }
        public string IsDeriverHandicap
        {
            get
            {
                return this.isDriverHandicap;
            }
            set
            {
                this.isDriverHandicap = value;
            }
        }
        public double RatePerHour
        {
            get
            {
                return this.ratePerHour;
            }
            set
            {
                this.ratePerHour = value;
            }
        }
        public string VehicleNumber
        {
            get
            {
                return this.vehicleNumber;
            }
            set
            {
                this.vehicleNumber = value;
            }
        }
        public double CustomerNumber
        {
            get
            {
                return this.customerNumber;
            }
            set
            {
                this.customerNumber = value;
            }
        }
    }
}
