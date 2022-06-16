using BuildingManagment.BLL.ServiceOperations;
using System;

namespace BuildingManagment.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroductionRegistrationManager.AddIntroduction();
            PostAnAdManager.AddPostAnAd();
            SaleAndRentManager.AddSaleAndRentManager();
            SupportServiceManager.AddSupportServiceManager();

            
        }
       
    }
}
