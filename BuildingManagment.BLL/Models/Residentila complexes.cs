using BuildingManagment.BLL.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Residentila_complexes
    {
        public string ID { get; set; }
        public int Phone { get; set; }
        public float PricebyArea { get; set; }
        public string Address { get; set; }
        public int MyProperty { get; set; }
        public Room Room { get; set; }
        public decimal Block { get; set; }
        public decimal Corpus { get; set; }
        public decimal Apartment { get; set; }
        public decimal Floor { get; set; }
        public float Area { get; set; }
        public RepairCondition RepairCondition { get; set; }
        public float PaymentTerms { get; set; }
        public string Advantages { get; set; }

    }
}
