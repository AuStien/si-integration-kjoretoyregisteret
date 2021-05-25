using System;
namespace KTR.Model
{
    public class OutData
    {
        public string CarBrand { get; set; }
        public string CarType { get; set; }
        public DateTime FirstTimeRegistration { get; set; }
        public string FuelType { get; set; }

        public OutData(string carBrand, string carType, DateTime firstTimeRegistration, string fuelType)
        {
            CarBrand = carBrand;
            CarType = carType;
            FirstTimeRegistration = firstTimeRegistration;
            FuelType = fuelType;
        }
    }
}
