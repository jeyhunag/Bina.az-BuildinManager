using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
    public class AgenciesManager
    {
        public static void AddAgencies()
        {
            Agencies agencies = new Agencies();
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Agentlik....................");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dasinmaz emlak agentliyi secin");
            Console.WriteLine("1-EVilla");
            Console.WriteLine("2-Lider");
            Console.WriteLine("3-Star Emlak");
            Console.WriteLine("4-Yeni Menzil");
            Console.WriteLine("5-Villa House");
            Console.WriteLine("6-City House");
            Console.WriteLine("7-Grand Emalk");
            Console.WriteLine("8-Caspro");
            agencies.Type = Console.ReadLine().ToLower();
            switch (agencies.Type)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
            }
            Console.WriteLine("Emlakin novunu secin");
            Console.WriteLine("1-Yeni tikililər");
            Console.WriteLine("2-Köhne tikililer");
            Console.WriteLine("3-Evler / Villalar");
            Console.WriteLine("4-Bağlar");
            Console.WriteLine("5-Ofisler");
            Console.WriteLine("6-Torpaq");
            Console.WriteLine("7-Obyektler");
            agencies.BuildingType = Console.ReadLine();
            switch (agencies.BuildingType)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;              
            }
            agencies.Mortgage = "var";
            agencies.Address = "Baki";
            agencies.Price = "125.654";
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Agentlik:"+agencies.Type);
            Console.WriteLine("Emlak novu: "+agencies.BuildingType);
            Console.WriteLine("Ipoteka: "+agencies.Mortgage);
            Console.WriteLine("Address: "+agencies.Address);
            Console.WriteLine("Qiymet: "+agencies.Price);
            Console.WriteLine("----------------------------------------------------");
        }
       
                
            
        
    }
}
