using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;

namespace Volvo_design_bureau.Warehouse
{
    public class Warehouse : Inventory
    {
        public Warehouse() : base()
        {
            List<CarBlueprint> startInventoryOfCars = new List<CarBlueprint>();
            startInventoryOfCars.Add(new SedanBlueprint("V60"));
            startInventoryOfCars.Add(new CrossoverBlueprint("XC90"));
            startInventoryOfCars.Add(new CrossoverBlueprint("XC40"));
            startInventoryOfCars.Add(new CrossoverBlueprint("XC40"));
            startInventoryOfCars.Add(new SedanBlueprint("V60"));
            startInventoryOfCars.Add(new SedanBlueprint("V40"));
            startInventoryOfCars.Add(new SedanBlueprint("V60"));
            startInventoryOfCars.Add(new CrossoverBlueprint("XC90"));
            startInventoryOfCars.Add(new CrossoverBlueprint("v60"));
            AddCarList(startInventoryOfCars);
        }
    }
}
