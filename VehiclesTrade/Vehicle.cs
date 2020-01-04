using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesTrade
{
    public interface IVehicle
    {
        string name { get; }
        float height { get; }
        float lengt { get; }
        float width { get; }
        int doors { get; }
        IEngine engine { get; }
        WheelDrive wd { get; }
    }
    public enum WheelDrive
    {
        AWD,
        BWD,
        FWD
    }
    public interface IEngine
    {
        string name { get; set; }
        double litres { get; set; }
        int hp { get; set; }
        int nm { get; set; }
    }
    public class Engine : IEngine
    {
        public string name { get => name; set => name = value; }
        public double litres { get => litres; set => litres = value; }
        public int hp { get => hp; set => hp = value; }
        public int nm { get => nm; set => nm = value; }
    }
}
