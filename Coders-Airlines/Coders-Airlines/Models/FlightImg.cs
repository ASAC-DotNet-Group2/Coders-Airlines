﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coders_Airlines.Models
{
    public class FlightImg
    {
        public int ID { get; set; }
        public int FlightID { get; set; }
        public string URL { get; set; }

        public Flight Flight { get; set; }
    }
}
