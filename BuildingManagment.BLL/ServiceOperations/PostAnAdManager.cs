using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
     public class PostAnAdManager
    {
        public static void AddPostAnAd()
        {
            Payment payment = new Payment();
            PostAnAd postAnAd = new PostAnAd();
            double Password1 = 0, Password2;
            bool PasswordLose = false, PasswordLose1 = false;
            Console.WriteLine("Elan yerlesdirmek isdeyirsinizmi? (He),(Yox)");
            string Users = Console.ReadLine().ToLower();
            if (Users=="he")
            {
                Console.WriteLine("Elan yerlesdirmek ucun muraciet...........");
                Console.WriteLine("Ilk elan qiymeti pulsuz daha sonra her elana 5 manat odenis olacag");
                Console.WriteLine("Tamm adinizi daxil edin");
                postAnAd.FullName = Console.ReadLine().ToLower();
                Console.WriteLine("Email unavnizi daxil edin");
                postAnAd.Email = Console.ReadLine().ToLower();
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


                Console.WriteLine("Elaniniz haqqinda melumat........");
                Console.WriteLine("Tamm adin: " + postAnAd.FullName);
                Console.WriteLine("Email: " + postAnAd.Email);
                Console.WriteLine("Telefon nomre: " + postAnAd.Phone);
                Console.WriteLine("Unvan: " + postAnAd.Address);
                Console.WriteLine("Elaqedar şexs: " + postAnAd.RelevantPerson);
                Console.WriteLine("Qiymet: " + postAnAd.Price);
                Console.WriteLine("Sekil: " + postAnAd.Pictures);
                Console.WriteLine("Etrafli melumat: " + postAnAd.AdditionalInformation);
            }
            else if (Users=="yox")
            {
              
            }
           


        }

        
    }
}
