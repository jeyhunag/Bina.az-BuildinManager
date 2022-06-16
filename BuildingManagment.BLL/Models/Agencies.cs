using BuildingManagment.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.Models
{
    public abstract class Agencies
    {
        public string ID { get; set; }
        public Mortgage Mortgage { get; set; }
    }
}
