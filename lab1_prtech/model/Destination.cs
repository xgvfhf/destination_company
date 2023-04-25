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
        
        public Destination(string track)
        {
            Track = track;             
        }
        public string Track { get; set; }
        public Manager RespMan { get; set; }
        
    }
}
