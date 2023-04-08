using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_prtech
{
    class Destination
    {
        public Destination(Stop st)
        {
            stops.Add(st);    
        }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public Manager RespMan { get; set; }
        List<Stop> stops;
    }
}
