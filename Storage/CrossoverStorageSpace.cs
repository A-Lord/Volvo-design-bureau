using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau.Storage
{
    public class CrossoverStorageSpace : Inventory
    {
        public CrossoverStorageSpace(HashSet<CrossoverBlueprint> CrossoverLis) : base()
        {
            AddCarHashSet(CrossoverLis);
        }
    }
}
