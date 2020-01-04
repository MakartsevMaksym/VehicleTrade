using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTrade
{
    public class AllCars
    {
        public List<IVehicle> Vehicles { get => vehicles; }
        List<IVehicle> vehicles = new List<IVehicle>()
        {
            new RAM_3500(), new RAM_4500(), new RAM_5500() 
        };
    }
    
    class RAM_3500 : IVehicle
    {
        public string name => "RAM 3500";
        
        public float height => 1965;
        
        public float lengt => 6100;
        
        public float width => 2006;
        
        public int doors => 4;

        public IEngine engine => new Engine()
        {
            name = "HP500",
            hp = 500,
            litres = 6.7,
            nm = 700
        };

        public WheelDrive wd => WheelDrive.AWD;
    }
    class RAM_4500 : IVehicle
    {
        public string name => "RAM 4500";
        
        public float height => 1965;
        
        public float lengt => 6100;
        
        public float width => 2006;
        
        public int doors => 4;

        public IEngine engine => new Engine()
        {
            name = "HP600",
            hp = 1500,
            litres = 6.7,
            nm = 700
        };

        public WheelDrive wd => WheelDrive.AWD;
    }
    class RAM_5500 : IVehicle
    {
        public string name => "RAM 3500";
        
        public float height => 1965;
        
        public float lengt => 6100;
        
        public float width => 2006;
        
        public int doors => 4;

        public IEngine engine => new Engine()
        {
            name = "HP700",
            hp = 2500,
            litres = 6.7,
            nm = 700
        };

        public WheelDrive wd => WheelDrive.AWD;
    }
}
