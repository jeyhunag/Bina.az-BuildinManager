using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;


namespace BuildingManagment.BLL.ServiceOperations
{
    public class IntroductionManager
    {


        public static void AddIntroduction()
        {
            Introduction introduction = new Introduction();
            double Password1 = 0;
            bool PasswordLose = false;
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Giris:");
            Console.WriteLine("-------------------------");
                Console.WriteLine($"Emailinizi daxil edin: ");
                introduction.Email = Console.ReadLine().ToLower();
                do
                {
                     Console.WriteLine($"Sifrenizi daxil edin: ");
                     introduction.Password = Console.ReadLine();
                     PasswordLose = double.TryParse(introduction.Password, out Password1);                     
                } while (PasswordLose == false);
                 DataOperations.Introductions.Add(introduction);         
        }
        public static void ShowIntroduction()
        {
           
            foreach (var item in DataOperations.Introductions)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Profil");
                Console.WriteLine("-------------------------");
                Console.WriteLine( $"Email: {item.Email}");
                Console.WriteLine($"Password: {item.Password}");
                Console.WriteLine("--------------------------");
            }
        }
       



    }
}
