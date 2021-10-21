using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;



namespace Volvo_design_bureau.Warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yaris = new SedanBlueprint("Toyota Yaris");
            var volvo = new TruckBlueprint("VoloLastbil");
            var nissan = new CrossoverBlueprint("Nissan");
            var volovWareHouse = new Warehouse();
            volovWareHouse.ShowInventory();
        }
    }
}
