using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            AllCars ac = new AllCars();
            foreach(IVehicle vec in ac.Vehicles)
            {
                Console.WriteLine($"{vec.wd.ToString()} | {vec.doors} | {vec.engine} \n");
                //Console.WriteLine($"{vec.name.ToString()} | {vec.doors} | {vec.engine} \n");
            }

            Console.ReadKey();
        }
    }
}
