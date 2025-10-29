using System;
using System.Text;
using System.IO;
using System.Xml;

namespace CarRentConsoleAppWithXML
{
    public class Program
    {
        public static void Main()
        {
            Start();
            Loop();
            read_from_XML_file();

        }

        private static void Start()
        {

        }

        private static void Loop()
        {

        }

        private static void write_to_XML_file()
        {

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

            for(int i=0;i<xNodeList.Count;i++)
            {
                Console.WriteLine("===============");
                Console.WriteLine("CAR_"+(i+1));
                Console.WriteLine("===============");


                for (int j=0;j<7;j++)
                {
                    str = xNodeList[i].ChildNodes.Item(j).InnerText.Trim();
                    Console.WriteLine(str);
                }
            }
        }

    }





}
