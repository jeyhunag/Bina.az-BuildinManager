using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.DLS
{
    public  class DataOperations
    {
        public  List<Introduction> Introductions { get; set; }
        public  DataOperations()
        {
            Introductions = new List<Introduction>();
        }

    }
}
