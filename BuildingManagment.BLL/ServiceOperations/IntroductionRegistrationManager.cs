using BuildingManagment.BLL.Models;
using System;


namespace BuildingManagment.BLL.ServiceOperations
{
    public class IntroductionRegistrationManager
    {


        public static void AddIntroduction()
        {
            Introduction introduction = new Introduction();
            Registration registration = new Registration();
            double Password1 = 0, Password2;
            bool PasswordLose = false, PasswordLose1 = false;
            Console.WriteLine($"Istifadeci adiniz varmi?(He),(Yox)");
            string User = Console.ReadLine().ToLower();
            if (User=="he")
            {              
                Console.WriteLine($"Giris....");               
                Console.WriteLine($"Emailinizi daxil edin: ");
                introduction.Email = Console.ReadLine().ToLower();
                do
                {
                     Console.WriteLine($"Sifrenizi daxil edin: ");
                     introduction.Password = Console.ReadLine();
                    PasswordLose = double.TryParse(introduction.Password, out Password1);

                } while (PasswordLose==false);              
                Console.WriteLine($"Email unvanini: " + introduction.Email);
                Console.WriteLine($"Sifre: " + introduction.Password);
                
                
            }
            else if (User=="yox")
            {
                Console.WriteLine("Qeydiyyat...");
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
                } while (PasswordLose1==false);
                
                Console.WriteLine("Sirket adi: " + registration.CompanyName);
                Console.WriteLine("Muvafiq şexs:" + registration.RelevantPerson);
                Console.WriteLine("Email: " + registration.Email);
                Console.WriteLine("Telefon nomresi: " + registration.Phone);
            }
           
               








        }

        
    }
}
