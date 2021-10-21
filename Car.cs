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
        private SelfdrivingComputer _steeringComputer { get; }

        public Car(string carName,int doors,int wheels,bool swheel,bool turnInd,bool hood,bool engine,bool AiDrive)
        {
            _modelName = carName;
            for (int i = 0; i < doors; i++)
            {
                _door.Add(new Door());
            }
            for (int i = 0;i < wheels;i++)
            {
                _wheels.Add(new Wheel());
            }
            _vinNumber = Guid.NewGuid();
            if (swheel)
            {
                _steeringWheel = new SteeringWheel();
            }
            if (turnInd)
            {
                _turnIndicator = new TurnIndicator();
            }
            if (hood)
            {
                _hood = new Hood();
            }
            if (engine)
            {
                _engine = new Engine();
            }
            if (AiDrive)
            {
                _steeringComputer = new SelfdrivingComputer();
            }

        }
    }
}
