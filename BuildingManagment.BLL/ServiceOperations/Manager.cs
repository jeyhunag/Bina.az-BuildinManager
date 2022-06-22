using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
    public class Manager<T>
    {
        public static void ServiceCall()
        {
            Type introduction = typeof(Introduction);
            if (typeof(T) == introduction)
            {
                IntroductionManager.AddIntroduction();
            }
            Type registration = typeof(Registration);
            if (typeof(T) == registration)
            {
                RegistrationManager.AddRegistration();
            }
            Type postAnAd = typeof(PostAnAd);
            if (typeof(T) == postAnAd)
            {
                PostAnAdManager.AddPostAnAd();
            }
            Type realEstate = typeof(RealEstateSale);
            if (typeof(T) == realEstate)
            {
                SaleAndRentManager.AddSaleAndRentManager();
            }
            Type agenciess = typeof(Agencies);
            if (typeof(T) == agenciess)
            {
                AgenciesManager.AddAgencies();
            }
            Type mortgage = typeof(Mortgage);
            if (typeof(T) == mortgage)
            {
                MortgageManager.AddMortgage();
                MortgageManager.ShowMortgage();
            }
            Type support_service = typeof(Support_Service);
            if (typeof(T) == support_service)
            {
                SupportServiceManager.AddSupportServiceManager();
            }

        }
    }
}
