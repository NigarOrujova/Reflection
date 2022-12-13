using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Flute : Instrument
    {
        public string Color { get; set; } = null!;
        public override string Sound()
        {
            return "Flute Sound";
        }
    }
}
