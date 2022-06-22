using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.DLS
{
    public  class DataOperations
    {
        public static  List<Introduction> Introductions { get; set; }
        public static List<Registration>Registrations { get; set; }
        public static List<PostAnAd>PostAnAds { get; set; }
        public static List<Support_Service>Support_Services { get;  }
        public static List<Mortgage>Mortgages { get; set; }
        static  DataOperations()
        {
            Introductions = new List<Introduction>();
            Registrations = new List<Registration>();
            PostAnAds = new List<PostAnAd>();
            Support_Services = new List<Support_Service>();
            Mortgages = new List<Mortgage>();
        }

    }
}
