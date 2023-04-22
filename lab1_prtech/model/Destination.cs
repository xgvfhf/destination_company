using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_prtech
{
    public class Destination
    {
        public Destination()
        {

        }
        public Destination(string pnta, string pntb, Stop st)
        {
            PointA = pnta;
            PointB = pntb;
            stops.Add(st);    
        }
        public string PointA { get; set; }
        public string PointB { get; set; }
        public Manager RespMan { get; set; }
        public List<Stop> stops = new List<Stop>();
    }
}
