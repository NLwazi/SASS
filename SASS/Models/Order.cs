using System;
using System.Collections.Generic;
using System.Text;

namespace SASS.Models
{
   public class Order
    {
        public string O_Id { get; set; }
        public string O_OrderNumber { get; set; }
        public string O_Status { get; set; }
        public DateTime o_DateOrdered { get; set; }
    }
}
