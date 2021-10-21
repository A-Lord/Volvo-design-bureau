using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volvo_design_bureau
{
    public abstract class SerialNumber
    {

        private Guid UniqID;
        protected SerialNumber()
        {
            UniqID = Guid.NewGuid();
        }


    }
}
