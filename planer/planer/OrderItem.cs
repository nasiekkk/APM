using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planer
{
    public class OrderItem
    {
        public int Amount { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }

        public OrderItem()
        {
            Amount = 0;
            Width = 0;
            Length = 0;
        }

        public OrderItem(int amount)
        {
            Amount = amount;
            Width = 0;
            Length = 0;
        }
    }
}
