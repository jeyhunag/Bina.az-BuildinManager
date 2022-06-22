using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Mortgage
    {
        public string ID { get; set; }
        public string Extract { get; set; }
        public float Price { get; set; }
        public int Room { get; set; }
        public string Address { get; set; }
        public float LoanRepayment { get; set; }
        public int TermOfMortgage { get; set; }
        public float InitalPayment { get; set; }
        public float OfficialIncome { get; set; }
        public Agencies Agencies { get; set; }
        public string BuildinType { get; set; }
        public int Term { get; set; }


    }
}
