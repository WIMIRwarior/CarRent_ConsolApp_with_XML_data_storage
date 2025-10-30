using System;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace CarRentConsoleAppWithXML
{
    public class Program
    {
        public static void Main()
        {
            read_from_XML_file();

            Car car_1 = new Car("Suzuki", "Samurai", "10.12.2015", 120000, "U27315TT22", true, 12);

            write_to_XML_file(car_1);

            read_from_XML_file() ;

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
            XmlDocument xmlDoc = new XmlDocument();
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), "Data_Storage.xml");
            XmlNodeList xNodeList;
            string? str = null;
            FileStream FS_Open_Read = new FileStream(FullPath,FileMode.Open, FileAccess.Read);
            xmlDoc.Load(FS_Open_Read);
            xNodeList = xmlDoc.GetElementsByTagName("car");

            for (int i = 0; i < xNodeList.Count; i++)
            {
                Console.WriteLine("===============");
                Console.WriteLine("CAR_" + (i + 1));
                Console.WriteLine("===============");


                for (int j = 0; j < 7; j++)
                {
                    str = xNodeList[i].ChildNodes.Item(j).InnerText.Trim();
                    Console.WriteLine(str);
                }
            }
            FS_Open_Read.Close();
        }


        private static void read_from_XML_file_2()
        {
            XDocument xmlDoc;
            var FullPath = Path.Combine(Directory.GetCurrentDirectory(), "Data_Storage.xml");
            xmlDoc = XDocument.Load(FullPath);
            xmlDoc.

        }
    }





}
