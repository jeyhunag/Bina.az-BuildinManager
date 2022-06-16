using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class RealEstateSale: RealEstate
    {
        public string Document { get; set; }
        public decimal Floor { get; set; }
        public Mortgage MortgageID { get; set; }
    }
}
