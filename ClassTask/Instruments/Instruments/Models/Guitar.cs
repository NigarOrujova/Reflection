﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.Models
{
    public class Guitar : Instrument
    {
        public string Type { get; set; } = null!;
        public override string Sound()
        {
            return "Guitar Sound";
        }
    }
}
