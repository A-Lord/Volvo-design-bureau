using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;

namespace Volvo_design_bureau.Warehouse
{
    public abstract class Inventory
    {
        private List<CarBlueprint> carList = new List<CarBlueprint>();
        protected Inventory()
        {
            
        }
        protected void AddCarList(List<CarBlueprint> newCarsList)
        {
            carList.AddRange(newCarsList);
        }
        protected void AddCar(CarBlueprint newCar)
        {
            carList.Add(newCar);
        }
        public void ShowInventory()
        {
            foreach (CarBlueprint car in carList)
                Console.WriteLine(car.ModelName);
        }
        public void FindFirstCarAndMoveToEnd(string carName)
        {
            var moveCar = carList.FindIndex(i => i.ModelName == carName);
            var copyOfcar = carList[moveCar];
            carList.RemoveAt(moveCar);
            carList.Add(copyOfcar);
        }
    }
}
