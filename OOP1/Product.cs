﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
        public int Id { get; set; }
        public double CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
       
        public int UnitsInStock { get; set; }

    }
}
