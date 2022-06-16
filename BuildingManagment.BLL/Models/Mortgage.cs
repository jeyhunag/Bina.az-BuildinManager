using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Mortgage
    {
        public string ID { get; set; }
        public string Extract { get; set; }
        public int TermOfMortgage { get; set; }
        public float CostOfApartment { get; set; }
        public float InitalPayment { get; set; }
        public float OfficialIncome { get; set; }
    }
}
