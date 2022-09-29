using LinqNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNetCore.Processors {
    public class PreLinq {
        public void Run()
        {
            var carStats = new CarsStatistics();
            carStats.ProcessFile("data/vehicles.csv");

            //Filtering Data
            //Get BMW
            var bmw = carStats.FilterBmw();
            var audi = carStats.FilterAudi();

            //we can do better 
            bmw = carStats.FilterByManufacturer("BMW");
            audi = carStats.FilterByManufacturer("Audi");

            //we can do even better
            bmw = carStats.Filter(p=>p.Manufacturer == "BMW");
            audi = carStats.Filter(p=>p.Manufacturer=="Audi");


            //Funcs?
            //Func<DateTime> getTime = () => DateTime.Now;

            Func<int, string, Employee> doWorkForEmp = (id, name) => {
                var emp = new Employee() { Id = id, FirstName = name };
                //emp.DoSomeOperationVeryComplex();
                return emp;
            };

            var emp = doWorkForEmp(10, "Orest");
            Console.WriteLine(emp);

            //var bmw = carStats.Filter(p => p.Manufacturer == "BMW");

            //extension

        }
    }
}
