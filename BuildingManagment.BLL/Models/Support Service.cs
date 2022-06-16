using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Support_Service
    {
        public string ID { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Complaint { get; set; }
        public List<Introduction> Introduction { get; set; }
    }
}
