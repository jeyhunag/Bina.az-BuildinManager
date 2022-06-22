using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Support_Service
    {
        public Support_Service()
        {
            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Complaint { get; set; }
        public List<Introduction> Introduction { get; set; }
    }
}
