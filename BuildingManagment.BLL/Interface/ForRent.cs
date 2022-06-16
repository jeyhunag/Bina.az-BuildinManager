using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Interface
{
    public class ForRent
    {
        public string ID { get; set; }
        public int Phone { get; set; }
        public RealEstateType RealEstateType { get; set; }
        public Room RoomID { get; set; }
        public int RentalPeriod { get; set; }
        public int Floor { get; set; }
    }
}
