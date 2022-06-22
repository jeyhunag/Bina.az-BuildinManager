using BuildingManagment.BLL.ServiceOperations;
using System;

namespace BuildingManagment.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("1. Hesaba giris");
            Console.WriteLine("2. Qeydiyyat");
            Console.WriteLine("3. Elan yerlesdir");
            Console.WriteLine("4. Dasinmaz emlakin satisi ve kirayesi");
            Console.WriteLine("5. Agentlik");
            Console.WriteLine("6. Ipoteka");
            Console.WriteLine("7. Destek xidmeti");
            Console.WriteLine("8. Cixis");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    IntroductionManager.AddIntroduction();
                    Menu();
                    break;
                case 2:
                    RegistrationManager.AddRegistration();
                    Menu();
                    break;
                case 3:
                    PostAnAdManager.AddPostAnAd();
                    Menu();
                    break;
                case 4:
                    SaleAndRentManager.AddSaleAndRentManager();
                    Menu();
                    break;
                case 5:
                    AgenciesManager.AddAgencies();
                    Menu();
                    break;
                case 6:
                    MortgageManager.AddMortgage();
                    MortgageManager.ShowMortgage();
                    Menu();
                    break;
                case 7:
                    SupportServiceManager.AddSupportServiceManager();
                    Menu();
                    break;
                case 8:
                    return;
                default:
                    break;
            }
        }

    }
}
