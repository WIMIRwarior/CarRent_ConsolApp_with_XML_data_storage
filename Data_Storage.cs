using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRentConsoleAppWithXML
{
    internal class Data_Storage
    {

        private static void write_to_XML_file(Car car, string filename)
        {
            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), filename);
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

        public static void SaveToXML(List<Car> Cars_List, string XML_file_name)
        {
            foreach (Car car in Cars_List)
            {
                write_to_XML_file(car, XML_file_name);
            }
        }


        public static List<Car> LoadFromXML(string XML_file_name)
        {
            List<Car> List_of_Cars = new List<Car>();

            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), XML_file_name);
            xmlDoc = XDocument.Load(FullPath);

            int i = 1;
            foreach (var car in xmlDoc.Descendants("car"))
            {
                List_of_Cars.Add(new Car(car.Element("brand")?.Value,
                                            car.Element("model")?.Value,
                                            car.Element("Year_of_production")?.Value,
                                            Convert.ToDouble(car.Element("mileage")?.Value),
                                            car.Element("VIN")?.Value,
                                            Convert.ToBoolean(car.Element("available")?.Value),
                                            Convert.ToDouble(car.Element("rent_fee")?.Value)));
            }
            return List_of_Cars;
        }

        private static void read_from_XML_file()
        {
            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), "Data_Storage.xml");
            xmlDoc = XDocument.Load(FullPath);

            int i = 1;
            foreach (var car in xmlDoc.Descendants())
            {
                Console.WriteLine("===CAR_" + i + "===");

                Console.WriteLine("Brand: " + car.Element("brand")?.Value);
                Console.WriteLine("Model: " + car.Element("model")?.Value);
                Console.WriteLine("Year of production: " + car.Element("Year_of_production")?.Value);
                Console.WriteLine("mileage: " + car.Element("mileage")?.Value);
                Console.WriteLine("VIN: " + car.Element("VIN")?.Value);
                Console.WriteLine("Availability: " + car.Element("available")?.Value);
                Console.WriteLine("Rent fee: " + car.Element("rent_fee")?.Value);

                Console.WriteLine("===================");

            }

        }
    }
}
