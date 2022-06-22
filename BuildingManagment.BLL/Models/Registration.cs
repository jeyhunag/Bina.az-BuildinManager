using BuildingManagment.BLL.Until;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Registration
    {
        public Registration()
        {
            ID = IDGenerator.GetCurrentTimeId();
        }
        public Int64 ID { get; set; }
        public string CompanyName { get; set; }
        public string RelevantPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
