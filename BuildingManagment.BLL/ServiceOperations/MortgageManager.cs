using BuildingManagment.BLL.DLS;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
    public class MortgageManager
    {
      public static void AddMortgage()
      {
            Mortgage mortgage = new Mortgage();
            Console.WriteLine("-------------------");
            Console.WriteLine("Ipoteka");
            Console.WriteLine("-------------------");
            Console.WriteLine("Emlakin novunu secin");
            Console.WriteLine("1-Yeni tikililəer");
            Console.WriteLine("2-Köhne tikililer");
            Console.WriteLine("3-Evler / Villalar");
            Console.WriteLine("4-Bağlar");
            Console.WriteLine("5-Ofisler");
            Console.WriteLine("6-Torpaq");
            Console.WriteLine("7-Obyektler");
            mortgage.BuildinType = Console.ReadLine();
            switch (mortgage.BuildinType)
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
            }
            Console.WriteLine("Otaq sayini girin");
            mortgage.Room = int.Parse(Console.ReadLine());
            Console.WriteLine("Unvani girin");
            mortgage.Address = Console.ReadLine().ToLower();
            Console.WriteLine($"Cixaris varmi? (He,Yox) ");
            mortgage.Extract = Console.ReadLine().ToLower();
            if (mortgage.Extract=="he")
            {
                Console.WriteLine("Cixaris var:");
            }
            else if (mortgage.Extract=="yox")
            {
                Console.WriteLine("Cixaris yoxdur: ");
            }
            Console.WriteLine($"Resmi gelirinizi yazin");
            mortgage.OfficialIncome = float.Parse(Console.ReadLine());
            Console.WriteLine($"Menzilin deyerini girin:");
            mortgage.Price = float.Parse(Console.ReadLine());
            Console.WriteLine($"Ilkin odenis girin ");
            mortgage.InitalPayment = float.Parse(Console.ReadLine());          
              Console.WriteLine("Ipotekanin muddetini girin ");
              mortgage.Term =int.Parse( Console.ReadLine());
            
            if (mortgage.Term<=120)
            {
                 
                 mortgage.LoanRepayment = (mortgage.Price - mortgage.InitalPayment) / mortgage.Term;
                       
            }
              DataOperations.Mortgages.Add(mortgage);  
      }
        public static  void ShowMortgage()
        {
            foreach (var item in DataOperations.Mortgages)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Ipoteka");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"Emlak: {item.BuildinType} ");
                Console.WriteLine($"Otaq sayi: {item.Room}");
                Console.WriteLine($"Address: {item.Address}");
                Console.WriteLine($"Cixaris: {item.Extract}");
                Console.WriteLine($"Resmi gelir: {item.OfficialIncome}");
                Console.WriteLine($"Menzilin deyeri: {item.Price}");
                Console.WriteLine($"Ilkin odenis: {item.InitalPayment}");
                Console.WriteLine($"Ipotekanin muddeti: {item.Term}");
                Console.WriteLine($"Kreditin aylig odenisi: {item.LoanRepayment.ToString("0.00")}");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
