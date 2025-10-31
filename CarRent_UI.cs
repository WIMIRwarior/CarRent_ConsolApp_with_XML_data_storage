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

        public static void Main_Menu()
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
            }

        }
    }
}
