using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BuildingManagment.BLL.ServiceOperations
{
     public class PostAnAdManager
    {
        public static void AddPostAnAd()
        {
                PostAnAd postAnAd = new PostAnAd();
                double Password1 = 0, Password2;
                bool PasswordLose = false, PasswordLose1 = false;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Elan yerlesdir...........");               
                Console.WriteLine("-----Qayda------Ilk elan qiymeti pulsuz daha sonra her elana 5 manat odenis olacag");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Tamm adinizi daxil edin");
                postAnAd.FullName = Console.ReadLine().ToLower();
                Console.WriteLine("Email unavnizi daxil edin");
                postAnAd.Email = Console.ReadLine().ToLower();
                Console.WriteLine("Dasinmaz emlakin novunu girin");
                Console.WriteLine("1-Yeni tikili");
                Console.WriteLine("2-Kohne tikili");
                Console.WriteLine("3-Ev/Villa");
                Console.WriteLine("4-Bag");
                Console.WriteLine("5-Ofis");
                Console.WriteLine("6-Qarac");
                Console.WriteLine("7-Torpaq");
                Console.WriteLine("8-Obyekt");
                postAnAd.Type = Console.ReadLine().ToLower();
                switch (postAnAd.Type)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                }
                do
                {
                 Console.WriteLine("Telefon nomrenizi daxil edin");
                 postAnAd.Phone = Console.ReadLine();
                 PasswordLose = double.TryParse(postAnAd.Phone, out Password1);
                } while (PasswordLose==false);
               
                Console.WriteLine("Unvani daxil edin");
                postAnAd.Address = Console.ReadLine().ToLower();
                Console.WriteLine("Emlak sahibinin adini daxil edin");
                postAnAd.RelevantPerson = Console.ReadLine().ToLower();
                do
                {
                 Console.WriteLine("Emlakin qiymetini daxil edin");
                 postAnAd.Price =Console.ReadLine();
                    PasswordLose1 = double.TryParse(postAnAd.Price, out Password2);
                } while (PasswordLose1==false);              
                Console.WriteLine("Dasinmaz emlakin sekillerini daxil edin: ");
                postAnAd.Pictures = Console.ReadLine().ToLower();
                Console.WriteLine("Dasinmaz emlak haqqinda elave melumatlari daxil edin: ");
                postAnAd.AdditionalInformation = Console.ReadLine().ToLower();
                Console.WriteLine($"Ipoteka olsunmu? (He)(Yox)");
                postAnAd.Mortgage = Console.ReadLine();
               if (postAnAd.Mortgage=="he")
               {

               }
               else if (postAnAd.Mortgage=="yox")
               {

               }
                DataOperations.PostAnAds.Add(postAnAd);
                Console.Clear();
        }
       
        public static void ShowPostAnAd()
        {
            foreach (var item in DataOperations.PostAnAds)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Elan......................");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Tamm ad: {item.FullName}");
                Console.WriteLine($"Email: {item.Email}");
                Console.WriteLine($"Emlak novu {item.Type}");
                Console.WriteLine($"Unvan: {item.Address}");
                Console.WriteLine($"Elaqe nomresi: {item.Phone}");
                Console.WriteLine($"Elaqedar şexs : {item.RelevantPerson}");
                Console.WriteLine($"Deyeri: {item.Price}");
                Console.WriteLine($"Elanin sekili: {item.Pictures}");
                Console.WriteLine($"Etrafli melumat: {item.AdditionalInformation}");
                Console.WriteLine($"Ipoteka: {item.Mortgage}");
                Console.WriteLine($"ID: {item.ID}");
                Console.WriteLine("----------------------------------------------------");
            }
        }

        
    }
}
