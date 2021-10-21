using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;



namespace Volvo_design_bureau.Storage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var yaris = new SedanBlueprint("Toyota Yaris");
            //var volvo = new TruckBlueprint("VoloLastbil");
            //var nissan = new CrossoverBlueprint("Nissan");
            //var volovWareHouse = new Warehouse();
            //volovWareHouse.ShowInventory();
            //Console.WriteLine();
            //volovWareHouse.FindFirstCarAndMoveToEnd("XC40");
            //volovWareHouse.FindFirstCarAndMoveToEnd("XC40");
            //volovWareHouse.ShowInventory();
            Dictionary<string, CrossoverBlueprint> CrossoverList = new Dictionary<string, CrossoverBlueprint>();
            CrossoverList.Add("XC40", new CrossoverBlueprint("XC40"));
            CrossoverList.Add("XC90", new CrossoverBlueprint("XC90"));
            CrossoverList.Add("XC90", new CrossoverBlueprint("XC90"));





            var VolvoWareHouse = new Warehouse();




        }
    }
}
