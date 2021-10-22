using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;

namespace Volvo_design_bureau.Storage
{
    public abstract class Inventory
    {
        private List<CarBlueprint> carList = new List<CarBlueprint>();
        private Dictionary<string, CrossoverBlueprint> CrossoverList= new Dictionary<string, CrossoverBlueprint>();
        private HashSet<CrossoverBlueprint> crossoverHashList= new HashSet<CrossoverBlueprint>();
        protected Inventory()
        {
            
        }
        protected void AddCarHashSet(HashSet<CrossoverBlueprint> newCarDictinary)
        {
            crossoverHashList = newCarDictinary;
        }

        protected void AddCarDictionary(Dictionary<string, CrossoverBlueprint> newCarDictinary)
        {
            CrossoverList = newCarDictinary;
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
        public List<CrossoverBlueprint> GetCarByColor(string color)
        {
            List<CrossoverBlueprint> coloredCar = new List<CrossoverBlueprint>();
            foreach (var car in crossoverHashList)
            {
                if (car._color == color)
                {
                    coloredCar.Add(car);
                }
            }
            return coloredCar;
        }
    }
}
