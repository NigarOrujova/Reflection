using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Piano : Instrument
    {
        public int Key { get; set; }
        public override string Sound()
        {
            return "Piano Sound";
        }
    }
}
