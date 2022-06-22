using BuildingManagment.BLL.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public class Introduction
    {
        

        public Introduction()
        {
            ID = Guid.NewGuid().ToString();
           

        }
       
        public  string Email { get; set; }
        public string Password { get; set; }
        public string ID { get; }
        public UsernameType Usernametype { get; set; }


    }
}
