﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planer
{
    public class Order
    {
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}