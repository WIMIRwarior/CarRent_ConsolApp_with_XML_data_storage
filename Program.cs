using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace CarRentConsoleAppWithXML
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                CarRent_UI.Display_App_Title();
                CarRent_UI.Main_Menu();

            }

        }

        private static void Start()
        {

        }

        private static void Loop()
        {

        }

        private static void write_to_XML_file(Car car)
        {
            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), "Data_Storage.xml");
            // FileStream FS_Open_Write = new FileStream(FullPath, FileMode.Open, FileAccess.ReadWrite);
            xmlDoc = XDocument.Load(FullPath);

            XElement xCar = new XElement("car",
                new XElement("brand", car.getBrand()),
                new XElement("model", car.getModel()),
                new XElement("Year_of_production", car.getYear_of_production()),
                new XElement("mileage", car.getMileage().ToString()),
                new XElement("VIN", car.getVIN()),
                new XElement("available", car.isAvailable().ToString()),
                new XElement("rent_fee", car.getRent_fee().ToString())
                );
            xmlDoc.Root.Add(xCar);
            xmlDoc.Save(FullPath);
        }


        private static void read_from_XML_file()
        {
            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), "Data_Storage.xml");
            xmlDoc = XDocument.Load(FullPath);

            int i = 1;
            foreach( var car in xmlDoc.Descendants())
            {
                Console.WriteLine("===CAR_" + i + "===");

                Console.WriteLine("Brand: " + car.Element("brand")?.Value);
                Console.WriteLine("Model: " + car.Element("model")?.Value);
                Console.WriteLine("Year of production: " + car.Element("Year_of_production")?.Value);
                Console.WriteLine("mileage: " + car.Element("mileage")?.Value);
                Console.WriteLine("VIN: "+car.Element("VIN")?.Value);
                Console.WriteLine("Availability: " + car.Element("available")?.Value);
                Console.WriteLine("Rent fee: " + car.Element("rent_fee")?.Value);

                Console.WriteLine("===================");

            }

        }
    }





}
