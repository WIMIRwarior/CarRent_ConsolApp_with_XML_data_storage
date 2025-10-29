using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentConsoleAppWithXML
{
    public class Car
    {
        private string brand;
        private string model;
        private string year_of_production;
        private double mileage;
        private string VIN;
        private bool available;
        private double rent_fee;

        public string getBrand()
        { return brand; }
        public string getModel() { return model; }
        public string getYear_of_production() { return year_of_production; }
        public double getMileage() { return mileage; }
        public double getRent_fee() { return rent_fee; }
        public string getVIN() { return VIN; }
        public bool isAvailable() { return available; }

        public void setAvailability(bool availability)
        { 
            this.available = availability; 
        }

        public void updateMileage(double kilometers)
        {
            this.mileage += kilometers;
        }

        public void setRent_Fee(double fee)
        {
            this.rent_fee = fee;
        }

        public Car(string brand, string model, string year_of_production, double mileage, string VIN, bool availability,double rentFee)
        {
            this.brand = brand;
            this.model = model;
            this.year_of_production = year_of_production;
            this.mileage = mileage;
            this.VIN = VIN;
            this.available = availability;
            this.rent_fee = rentFee;
        }


    }
}
