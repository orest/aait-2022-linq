using System.Security.Cryptography;

namespace LinqNetCore.Models.Cars {
    public class Car {
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string VehicleClass { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public double City { get; set; }
        public double Highway { get; set; }
        public double Combined {
            get {
                // Combined fuel economy is a weighted average of City and Highway MPG values that is calculated by weighting the City value by 55% and the Highway value by 45%.
                var combined = (City * 0.55) + (Highway * 0.45);
                return combined;
            }
        }

        public double SaveOrSpend { get; set; }
        public string FuelType { get; set; }
    }
}
