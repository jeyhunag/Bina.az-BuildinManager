using BuildingManagment.BLL.Models;
using BuildingManagment.BLL.ServiceOperations;
using System;

namespace BuildingManagment.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
                    Manager<Introduction>.ServiceCall();
                    IntroductionManager.ShowIntroduction();
                    Menu();
                    break;
                case 2:
                    Manager<Registration>.ServiceCall();
                    RegistrationManager.ShowRegistration();
                    Menu();
                    break;
                case 3:
                    Manager<PostAnAd>.ServiceCall();
                    PostAnAdManager.ShowPostAnAd();
                    Menu();
                    break;
                case 4:
                    Manager<RealEstateSale>.ServiceCall();
                    Menu();
                    break;
                case 5:
                    Manager<Agencies>.ServiceCall();
                    Menu();
                    break;
                case 6:
                    Manager<Mortgage>.ServiceCall();
                    MortgageManager.ShowMortgage();
                    Menu();
                    break;
                case 7:
                    Manager<Support_Service>.ServiceCall();
                    SupportServiceManager.ShowSupport_Services();
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
