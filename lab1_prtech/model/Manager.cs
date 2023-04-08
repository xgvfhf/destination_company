using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_prtech
{
   public class Manager : User
    {
        public string isAdmin { get; set; }
        public string ManLicNum { get; set; }
        public Cargo Cargo { get; set; }
    }
}
