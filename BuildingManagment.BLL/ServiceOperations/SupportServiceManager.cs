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
            Console.WriteLine("Texniki destek xidmetine ehtiyaciniz varmi? (He),(Yox) ");
            string Support = Console.ReadLine().ToLower();
            if (Support=="he")
            {
                do
                {
                  Console.WriteLine("Elaqe nomrenizi girin ");
                  support_Service.Phone = Console.ReadLine();
                    PasswordLose = double.TryParse(support_Service.Phone, out Password1);
                } while (PasswordLose==false);
               
                Console.WriteLine("Texniki probleminizi yazin ");
                support_Service.Complaint = Console.ReadLine().ToLower();
                Console.WriteLine("Destek xidmeti....");
                Console.WriteLine("Elaqe nomreniz: "+ support_Service.Phone);
                Console.WriteLine("Texniki probleminiz: "+ support_Service.Complaint);
                Console.WriteLine("Tesekkur edirik tezlikle sizinle elaqe saxlanilacag....");
            }
            else if (Support=="Yox")
            {

            }
            
            

        }
    }
}
