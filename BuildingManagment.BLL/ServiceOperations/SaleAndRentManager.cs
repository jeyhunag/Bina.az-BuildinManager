using BuildingManagment.BLL.Interface;
using BuildingManagment.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagment.BLL.ServiceOperations
{
    public class SaleAndRentManager
    {

        public static void AddSaleAndRentManager()
        {

            Console.WriteLine("Dasinmaz emlak isdeyirsinizmi? (He),(Yox)");
            string Type = Console.ReadLine().ToLower();
            if (Type=="he")
            {
                Room room = new Room();
                Mortgage mortgage = new Mortgage();
                RealEstateSale realEstate = new RealEstateSale();
                ForRent forRent1 = new ForRent();
                ForRent forRent = forRent1;               
                Console.WriteLine("Dasinmaz emlakin novunu girin");
                Console.WriteLine("1-Yeni tikili");
                Console.WriteLine("2-Kohne tikili");
                Console.WriteLine("3-Ev/Villa");
                Console.WriteLine("4-Bag");
                Console.WriteLine("5-Ofis");
                Console.WriteLine("6-Qarac");
                Console.WriteLine("7-Torpaq");
                Console.WriteLine("8-Obyekt");
                string Typee = Console.ReadLine();
                switch (Typee)
                {
                    case "1":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales = Console.ReadLine().ToLower();
                        if (sales=="alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: "+ realEstate.Area);
                            Console.WriteLine("Qiymet: "+ realEstate.Price);
                            Console.WriteLine("Mertebe: "+ realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: "+ realEstate.Adress);
                            Console.WriteLine("Otag sayi: "+ room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: "+ mortgage.Extract);
                        }
                        else if (sales=="kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: "+ forRent.Floor);
                            Console.WriteLine("ID: "+ forRent.ID);
                            Console.WriteLine("Muddet: "+ forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales1 = Console.ReadLine().ToLower();
                        if (sales1 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Mertebe: " + realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales1 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales2 = Console.ReadLine().ToLower();
                        if (sales2 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Mertebe: " + realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales2 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "4":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales3 = Console.ReadLine().ToLower();
                        if (sales3 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Mertebe: " + realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales3 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales4 = Console.ReadLine().ToLower();
                        if (sales4 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Mertebe: " + realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales4 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "6":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales5 = Console.ReadLine().ToLower();
                        if (sales5 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.Adress = "Baki";
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales5 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "7":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales6 = Console.ReadLine().ToLower();
                        if (sales6 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.Adress = "Baki";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                        }
                        else if (sales6 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                    case "8":
                        Console.WriteLine("Hansi meqsedle isdeysiz? (Alis),(Kiraye)");
                        string sales7 = Console.ReadLine().ToLower();
                        if (sales7 == "alis")
                        {
                            realEstate.Area = 1522;
                            realEstate.Price = 25000;
                            realEstate.ID = "2";
                            realEstate.NumberOfFloors = 2;
                            realEstate.Adress = "Baki";
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Sahesi: " + realEstate.Area);
                            Console.WriteLine("Qiymet: " + realEstate.Price);
                            Console.WriteLine("Mertebe: " + realEstate.NumberOfFloors);
                            Console.WriteLine("Unvan: " + realEstate.Adress);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        else if (sales7 == "kiraye")
                        {
                            forRent.Floor = 5;
                            forRent.ID = "5";
                            forRent.RentalPeriod = 28;
                            room.NumberOfRoom = 5;
                            mortgage.Extract = "Var";
                            Console.WriteLine("Mertebe: " + forRent.Floor);
                            Console.WriteLine("ID: " + forRent.ID);
                            Console.WriteLine("Muddet: " + forRent.RentalPeriod);
                            Console.WriteLine("Otag sayi: " + room.NumberOfRoom);
                            Console.WriteLine("Ipoteka: " + mortgage.Extract);
                        }
                        break;
                }

            }
            else if (Type=="Yox")
            {

            }
        }

       
    }
}
