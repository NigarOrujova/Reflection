using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public abstract class Instrument
    {
        public string Model { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public double Price { get; set; }
        public abstract string Sound();
    }
}
