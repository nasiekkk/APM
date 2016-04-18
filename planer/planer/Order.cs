using Planer.MVVM_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planer
{
    public class Order : ObservableObject
    {
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; } 
        
        
    }

   

}
