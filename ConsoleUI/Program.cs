using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();
         
            Car camry = new Car() { hasTrunk = true, Make = "Toyota", Model = "Camry", Year = 2010};
           
            Motorcycle honda = new Motorcycle() { hasSideCart = true, Make = "Honda", Model = "Pionner", Year = 2012 };

            Vehicle limo = new Car() { hasTrunk = false, Make = "Cadillac", Model = "XST", Year = 2012 };

            Vehicle convertible = new Car() { Make = "Porsche", Model = "Boxster", Year = 2013 };

            vehicles.Add(camry);
            vehicles.Add(honda);
            vehicles.Add(convertible);
            vehicles.Add(limo);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                //vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("==============================================");
            }
        }
    }
}
