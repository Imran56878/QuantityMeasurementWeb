using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ParkingLotModel
{
    public class ParkingModel
    {
        int parkingSlotNumber;
        string vehicleType;
        DateTime timeIn;
        DateTime timeOut;
        double ratePerHour;
        string vehicleNumber;
        string parkingType;
        string driverType;
        string vehicleColor;
        string vehicleModel;

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ParkingSlotNumber
        {
            get
            {
                return this.parkingSlotNumber;
            }
            set
            {
                this.parkingSlotNumber = value;
            }
        }
        public string VehicleType
        {
            get
            {
                return this.vehicleType;
            }
            set
            {
                this.vehicleType = value;
            }
        }
        public DateTime TimeIn
        {
            get
            {
                return this.timeIn;
            }
            set
            {
                this.timeIn = value;
            }
        }
        public DateTime TimeOut
        {
            get
            {
                return this.timeOut;
            }
            set
            {
                this.timeOut = value;
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
        public string ParkingType
        {
            get
            {
                return this.parkingType;
            }
            set
            {
                this.parkingType = value;
            }
        }
        public string DeriverType
        {
            get
            {
                return this.driverType;
            }
            set
            {
                this.driverType = value;
            }
        }
        public string VehicleColor
        {
            get
            {
                return this.vehicleColor;
            }
            set
            {
                this.vehicleColor = value;
            }

        }
        public string VehicleModel
        {
            get
            {
                return this.vehicleModel;
            }
            set
            {
                this.vehicleModel = value;
            }
        }
    }
}