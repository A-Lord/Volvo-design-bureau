using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public class CrossoverBlueprint : CarBlueprint
    {
        private static readonly List<Door> doors = new List<Door> { new Door(), new Door(), new Door(), new Door() };
        private static readonly List<Wheel> wheels = new List<Wheel> { new Wheel(), new Wheel(), new Wheel(), new Wheel() };

        //public override int GetHashCode() { /* Implementation */ }
        //public override bool Equals(object obj) { /* Implementation */ }
        public CrossoverBlueprint(string carName) : base(carName,"Crossover", doors, wheels, new SteeringWheel(), new TurnIndicator(), new Hood(), new Engine())
        {

        }

    }
}
