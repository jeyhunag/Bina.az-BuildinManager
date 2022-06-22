using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BuildingManagment.BLL.ServiceOperations
{
    public   class RegistrationManager
    {
        public static void AddRegistration()
        {
            Registration registration = new Registration();
            double  Password2;
            bool PasswordLose1 = false;
            Console.WriteLine("-------------------------");
            Console.WriteLine("Qeydiyyat...");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Sirketin adini daxil edin: ");
            registration.CompanyName = Console.ReadLine().ToLower();
            Console.WriteLine("Elaqedar sexsin adini daxil edin: ");
            registration.RelevantPerson = Console.ReadLine().ToLower();
            Console.WriteLine("Email unvaninizi daxil edin: ");
            registration.Email = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("Telefon nomrenizi daxil edin: ");
                registration.Phone = Console.ReadLine();
                PasswordLose1 = double.TryParse(registration.Phone, out Password2);
               
            } while (PasswordLose1 == false);              
                DataOperations.Registrations.Add(registration);
        }      
        public static void ShowRegistration()
        {
            foreach (var item in DataOperations.Registrations)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Qeydiyyatdan ugurla kecdiniz.............");
                Console.WriteLine("Profil...........");
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Sirketin Adi:{item.CompanyName}");
                Console.WriteLine($"Muvafiq şexs: {item.RelevantPerson}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Elaqe Nomresi: {item.Phone}");
                Console.WriteLine($"ID: {item.ID}");
                Console.WriteLine("----------------------------------------------------");
            }

        }
       
    }
}
