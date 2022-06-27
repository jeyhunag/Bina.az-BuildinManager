using BuildingManagment.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public  class Agencies
    {
        public Agencies()
        {

            ID = Guid.NewGuid().ToString();
        }
        public string ID { get; }
        public string Mortgage { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int BuildingType { get; set; }
        public string Address { get; set; }
        public string Price { get; set; }
    }
}
