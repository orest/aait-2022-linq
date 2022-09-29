using LinqNetCore.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNetCore.Processors {
    public class CarsStatistics {
        private List<Car> _cars = new List<Car>();

        public List<Car> ProcessFile(string path) {
            var query =
                File.ReadAllLines(path)
                    .Skip(1)
                    .Where(l => l.Length > 1)
                    .Select(ParseCarFromFile);

            _cars = query.ToList().Where(p => p != null).ToList();

            return _cars;
        }

        public static Car ParseCarFromFile(string line) {
            //cylinders	displ	drive	fuelType	make	model	mpgData	phevBlended	trany	UCity	UHighway	VClass	year	youSaveSpend
            // 0        1       2       3           4       5       6       7           8       9        10         11      12      13
            var columns = line.Split(',');
            var c = new Car();
            if (int.TryParse(columns[0], out int cylinders)) {
                c.Cylinders = cylinders;
                c.Displacement = double.Parse(columns[1]);
                c.FuelType = columns[3];
                c.Manufacturer = columns[4];
                c.Model = columns[5];
                c.City = double.Parse(columns[9]);
                c.Highway = double.Parse(columns[10]);
                c.VehicleClass = columns[11];
                c.Year = int.Parse(columns[12]);
                c.SaveOrSpend = double.Parse(columns[13]);
                return c;
            }

            return null;
        }

        public List<Car> FilterBmw() {
            var cars = new List<Car>();
            foreach (var car in _cars) {
                if (car.Manufacturer == "BMW") {
                    cars.Add(car);
                }
            }
            return cars;
        }

        public List<Car> FilterAudi() {
            var cars = new List<Car>();
            foreach (var car in _cars) {
                if (car.Manufacturer == "Audi") {
                    cars.Add(car);
                }
            }

            return cars;
        }

        public List<Car> FilterByManufacturer(string manufacturer) {
            var cars = new List<Car>();
            foreach (var car in _cars) {
                if (car.Manufacturer == manufacturer) {
                    cars.Add(car);
                }
            }

            return cars;
        }


        public List<Car> Filter(Func<Car, bool> func) {
            var cars = new List<Car>();
            foreach (var car in _cars) {
                if (func(car)) {
                    cars.Add(car);
                }
            }

            return cars;
        }
    }


}
