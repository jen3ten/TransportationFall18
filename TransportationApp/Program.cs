using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace TransportationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck ford = new Truck();
            Console.WriteLine(ford.GetMph(65));

            Car fordCar = new Car();
            Console.WriteLine(fordCar.GetMpg(30, 2));

            Motorcycle bmwCycle = new Motorcycle();
            Console.WriteLine(bmwCycle.GetMph(40));
        }
    }
}
