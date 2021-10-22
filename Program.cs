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
            //Dictionary<string, CrossoverBlueprint> CrossoverList = new Dictionary<string, CrossoverBlueprint>();
            //CrossoverList.Add("XC40", new CrossoverBlueprint("XC40"));
            //CrossoverList.Add("XC90", new CrossoverBlueprint("XC90"));
            //CrossoverList.Add("XC90", new CrossoverBlueprint("XC90"));


            HashSet<CrossoverBlueprint> crossoverBlueprints = new HashSet<CrossoverBlueprint>();
            Random random= new Random();
            var carColorRed = "Red";
            var carColorGreen = "Green";
            var carColorWhite = "White";
            var carPickedColorString = "";
            for (int i = 0; i < 10000; i++)
            {
                var colorPickID = random.Next(0, 4);
                switch (colorPickID)
                {   
                    case 0:
                        carPickedColorString = carColorRed;
                        break;
                        case 1:
                            carPickedColorString = carColorGreen;
                        break;
                        case 2:
                            carPickedColorString = carColorWhite;
                        break;
                    default:
                        break;
                }
                if (random.Next(0,2) == 1)
                {
                    crossoverBlueprints.Add(new CrossoverBlueprint("XC40", carPickedColorString));
                }
                else
                {
                    crossoverBlueprints.Add(new CrossoverBlueprint("XC90", carPickedColorString));
                }

            }




            var VolvoWareHouse = new Warehouse(crossoverBlueprints);
            VolvoWareHouse.GetAndCountCarsOfColor("White");



        }
    }
}
