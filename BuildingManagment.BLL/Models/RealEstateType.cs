using BuildingManagment.BLL.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public  class   RealEstateType:RealEstate
    {
        public new string ID { get; set; }
        public BuildingType buildingType;
        public string Garden { get; set; }
        public string Office { get; set; }
        public string HomeVilla { get; set; }
        public string  Garage { get; set; }
        public string Land { get; set; }
        public string Object { get; set; }

    }
}
