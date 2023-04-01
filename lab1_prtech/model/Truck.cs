using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_prtech
{
    class Truck
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Odometr { get; set; }
        public string Fuel { get; set; }
        public Driver Driver { get; set; }
        public Cargo Cargo { get; set; }
        public Destination Destination { get; set; }

    }
}
