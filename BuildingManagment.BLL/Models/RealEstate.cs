using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
     public abstract class RealEstate
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }
        public DateTime OriginHistory { get; set; }
        public string Email { get; set; }
        public decimal NumberOfFloors { get; set; }
        public float Price { get; set; }
        public float Area { get; set; }
        public RealEstateType RealEstateType { get; set; }


    }
}
