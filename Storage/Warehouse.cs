using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volvo_design_bureau;

namespace Volvo_design_bureau.Storage
{
    public class Warehouse
    {
        private CrossoverStorageSpace _crossoverStorageSpace;
        private SedanStorageSpace _sedanStorageSpace;

        public Warehouse(HashSet<CrossoverBlueprint> crossoversList) 
        {
            _crossoverStorageSpace = new CrossoverStorageSpace(crossoversList);
        }
        public Warehouse(HashSet<SedanBlueprint> sedanList)
        {

        }
        //public Warehouse(HashSet<CarBlueprint> genericCars)
        //{
        //    HashSet<CrossoverBlueprint> crossoversList = new HashSet<CrossoverBlueprint>();
        //    HashSet<SedanBlueprint> sedanList = new HashSet<SedanBlueprint>();

        // To:do Att way to move all CrossoverBlueprint objects from genericCars hashset to the new Crossover only hashset. 
        //}
    }
}
