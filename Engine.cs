using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public class Engine
    {
        private Guid SerialNumber { get; }
        public Engine()
        {
            SerialNumber = Guid.NewGuid();
        }

    }
}
