using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public abstract class CarBlueprint
    {
        

        public string ModelName { get; private init; }
        private int _carPrice;
        public string _color = "";
        private string TypeOfCar { get; }
        private List<Door> Door = new List<Door>();
        private Guid VinNumber { get; }
        private List<Wheel> Wheels = new List<Wheel>();
        private SteeringWheel SteeringWheel { get; }
        private TurnIndicator TurningIndicator { get; }
        private Hood Hood { get; }
        private Engine Engine { get; }
        
        public int CarPrice { get {  return _carPrice; } private set { _carPrice = value; } }
            

        public CarBlueprint(string carName,string typeOfCar,List<Door> doors,List<Wheel> wheels,SteeringWheel swheel,TurnIndicator turnInd,Hood hood,Engine engine)
        {

            ModelName = carName;
            TypeOfCar = typeOfCar;
            Door.AddRange(doors);
            Wheels.AddRange(wheels);
            TurningIndicator = turnInd;
            Hood = hood;
            Engine = engine;

        }
        public override int GetHashCode() { return this; }

    }
}
