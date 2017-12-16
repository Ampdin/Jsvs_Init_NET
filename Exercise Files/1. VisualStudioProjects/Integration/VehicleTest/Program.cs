using CarComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           CarSDK car = new CarSDK();
            Console.WriteLine(car.RevEngine());
        }
    }
}
