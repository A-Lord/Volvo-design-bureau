using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau.Storage
{
    public class SedanStorageSpace : Inventory
    {
        public SedanStorageSpace(Dictionary<string, CrossoverBlueprint> CrossoverLis) : base()
        {
            AddCarDictionary(CrossoverLis);
        }

    }
}
