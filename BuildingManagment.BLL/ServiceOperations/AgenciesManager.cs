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
            Console.WriteLine("Dasinmaz emlak agentliyi secin: (EVilla:1,Lider:2,StarEmlak:3,YeniMenzil:4," +
                "VillaHouse:5,CityHouse:6,GrandEmalk:7,Caspro:8)");
            agencies.Type = int.Parse(Console.ReadLine());
            Console.WriteLine("Emlakin novunu secin: (YeniTikililər:1,KöhneTikililer:2,EvlerVillalar:3," +
                                "Bağlar:4, Ofisler:5, Torpaq:6,Obyektler:7) ");
            agencies.BuildingType = int.Parse(Console.ReadLine());
            agencies.Mortgage = "var";
            agencies.Address = "Baki";
            agencies.Price = "125.654";
            Console.Clear();
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
