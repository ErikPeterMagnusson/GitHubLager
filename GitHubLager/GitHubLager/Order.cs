﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubLager
{
    class Order
    {
        public int          OrderNumber         { get; set; }
        public string       Customer            { get; set; }
        public string       Vendor              { get; set; }
        public string       OrderDescription    { get; set; }
        public string       ShippingAdress      { get; set; }
    }
}
