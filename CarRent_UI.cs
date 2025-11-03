using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentConsoleAppWithXML
{
    internal class CarRent_UI
    {
        public static void Display_App_Title()
        {
            Console.WriteLine("***SEAT DYNAMICA CAR RENT***\n");
        }

        public static void Main_Menu(List<Car> List_of_Cars)
        {
            int? choice = null;


            Console.WriteLine("===========MENU===========");
            Console.WriteLine("1) EXIT");
            Console.WriteLine("2) SHOW ALL CARS");
            Console.WriteLine("3) SHOW ONLY AVAILABLE");
            Console.WriteLine("4) SHOW ONLY RENTED");
            Console.WriteLine("5) ADD NEW CAR");
            Console.WriteLine("6) SEARCH FOR CAR BY PARAMS");
            Console.WriteLine("===========================");

            choice = Convert.ToInt32(Console.ReadLine());
                
            switch(choice) {
                case 1: Environment.Exit(0);
                    break;
                case 2:
                    Show_all_cars(List_of_Cars);
                    Console.ReadKey();
                    break;
            }

        }

        public static void Show_all_cars(List<Car> List_of_Cars)
        {
            Console.Clear();
            Display_App_Title();

            int i = 1;
            foreach(Car car in List_of_Cars)
            {
                Console.WriteLine("=====CAR{" + i + "}=====");
                Console.WriteLine("BRAND: " + car.getBrand());
                Console.WriteLine("MODEL: " + car.getModel());
                Console.WriteLine("YEAR OF PRODUCTION: " + car.getYear_of_production());
                Console.WriteLine("MILEAGE: " + car.getMileage().ToString()+"km");
                Console.WriteLine("VIN: " + car.getVIN());
                Console.WriteLine("AVAILABILITY: " + car.isAvailable().ToString());
                Console.WriteLine("RENT FEE: " + car.getRent_fee().ToString()+"$");
                i++;
            }
        }

    }
}
