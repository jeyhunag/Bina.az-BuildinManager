using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
    public class SupportServiceManager
    {
        public static void AddSupportServiceManager()
        {
            Support_Service support_Service = new Support_Service();
            double Password1 = 0;
            bool PasswordLose = false;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Texniki destek xidmeti: ");
            Console.WriteLine("----------------------------------");
            do
            {
                  Console.WriteLine("Elaqe nomrenizi girin ");
                  support_Service.Phone = Console.ReadLine();
                    PasswordLose = double.TryParse(support_Service.Phone, out Password1);
                } while (PasswordLose==false);               
                Console.WriteLine("Texniki probleminizi yazin ");
                support_Service.Complaint = Console.ReadLine().ToLower();
                DataOperations.Support_Services.Add(support_Service);                                 
        }
        public static void ShowSupport_Services()
        {
            foreach (var item in DataOperations.Support_Services)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Destek xidmeti....................");
                Console.WriteLine("----------------------------------");
                Console.WriteLine($"Elaqe: {item.Phone}");
                Console.WriteLine($"Texniki problem: {item.Complaint}");
                Console.WriteLine("Tesekkur edirik tezlikle sizinle elaqe saxlanilacag....");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
