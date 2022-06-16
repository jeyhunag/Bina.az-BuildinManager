using BuildingManagment.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class DailyRentApartments
    {
        public string ID { get; set; }
        public RealEstateType RealEstateType { get; set; }
        public Room Room { get; set; }
    }
}
