﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public class Sedan : Car
    {
        private SelfdrivingComputer _steeringComputer { get; }
        private static readonly List<Door> doors = new List<Door> { new Door(),new Door(),new Door(),new Door()};
        private static readonly List<Wheel> wheels = new List<Wheel> { new Wheel(), new Wheel(), new Wheel(), new Wheel() };
        public Sedan(string carName) : base(carName, doors,wheels,new SteeringWheel(),new TurnIndicator(),new Hood(),new Engine())
        {
            _steeringComputer = new SelfdrivingComputer();
        }
    }
}
