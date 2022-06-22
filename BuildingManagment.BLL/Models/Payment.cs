using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Payment
    {
        public Payment()
        {
            ID = Guid.NewGuid().ToString();


        }
        public string ID { get; set; }
        public decimal PaymentByCard { get; set; }
    }
}
