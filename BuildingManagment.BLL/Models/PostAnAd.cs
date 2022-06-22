using BuildingManagment.BLL.Until;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public   class PostAnAd
    {
        public PostAnAd()
        {
            ID = IDGenerator.GetCurrentTimeId();
        }

        public Int64  ID { get; }
        public string FullName { get; set; }
        public string RelevantPerson { get; set; }
        public float Area { get; set; }
        public string Price { get; set; }
        public string Email { get; set; }
        public string Pictures { get; set; }
        public string AdditionalInformation { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Mortgage { get; set; }



    }

}

   



