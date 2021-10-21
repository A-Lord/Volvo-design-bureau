using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public abstract class Car
    {
        private string _modelName { get; }
        private List<Door> _door { get; }
        private Guid _vinNumber { get; }
        private List<Wheel> _wheels { get; }
        private SteeringWheel _steeringWheel { get; }
        private TurnIndicator _turnIndicator { get; }
        private Hood _hood { get; }
        private Engine _engine { get; }


        public Car(string carName,List<Door> doors,List<Wheel> wheels,SteeringWheel swheel,TurnIndicator turnInd,Hood hood,Engine engine)
        {
            _modelName = carName;
            _door.AddRange(doors);
            _wheels.AddRange(wheels);
            _turnIndicator = turnInd;
            _hood = hood;
            _engine = engine;

        }
    }
}
