using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace _5.Ulesanne
{
    public class BikeBuilder : IBike
    {
        public BikeBuilder()
        {
            reset();
        }

        public BikeBuilder(string make)
        {
            reset();
            bikeMake = make;
            Console.WriteLine("\nYou are making Your pesonal " + make + " bike\n");
        }

        public string bikeMake { get; set; }
        public string bikeColor { get; set; }
        public int engineKW { get; set; }
        public double engineDisplacement { get; set; }
        public int year { get; set; }
        public int millage { get; set; }
        public string transmission { get; set; }
        public string bodyType { get; set; }
        public int seatsNumber { get; set; }
        public string drivingLicenseCategory { get; set; }
        public int price { get; set; }
        public bool isOnAdditionalEquipment = false;
        public List<string> additionalEquipment = new List<string>();

        public int GetPrice() //!!!!!!! ENGINE DISPLACEMENT
        {
            if (year >= 2015)
            {
                price = 20000 - ((2020 - year) * 2000);
            }
            if (year < 2015 && year >= 2001)
            {
                price = 20000 - ((2020 - year) * 1000);
            }
            if (year < 2001) 
            {
                price = 1500;
            }

            price += Convert.ToInt32(engineDisplacement * 1);

            if (transmission == "AUTOMAT") // TRANSMISSION
            {
                price += 1000;
            }
            if (bodyType == "CUSTOM")
            {
                price += 1000;
            }
            if (bodyType == "CHOPPER")
            {
                price += 500;
            }
            if (bodyType == "STREET")
            {
                price -= 250;
            }
            if (bodyType == "SPORT")
            {
                price += 1250;
            }
            if (bodyType == "TOURING")
            {
                price += 250;
            }
            if (bodyType == "SCOOTER")
            {
                price -= 800;
            }
            if (bodyType == "ENDURO")
            {
                price -= 500;
            }

            if (additionalEquipment.Contains("Turbo Kit"))
            {
                price += 500;
            }
            if (additionalEquipment.Contains("Anti-wheelie system"))
            {
                price += 200;
            }
            if (additionalEquipment.Contains("Auto clutch"))
            {
                price += 200;
            }
            if (additionalEquipment.Contains("ABS"))
            {
                price += 200;
            }

            return price;
        }

        public void reset()
        {
            bikeMake = null;
            bikeColor = null;
            engineKW = 0;
            year = 0;
            millage = 0;
            transmission = null;
            bodyType = null;
            seatsNumber = 0;
            engineDisplacement = 0;
            drivingLicenseCategory = null;
            price = 0;
        }

        public int setBodyType(string _bodyType)
        {
            bodyType = _bodyType;
            if (bodyType == "CUSTOM")
            {
                seatsNumber = 1;
            }
            if (bodyType == "CHOPPER")
            {
                seatsNumber = 2;
            }
            if (bodyType == "STREET")
            {
                seatsNumber = 2;
            }
            if (bodyType == "SPORT")
            {
                seatsNumber = 2;
            }
            if (bodyType == "TOURING")
            {
                seatsNumber = 2;
            }
            if (bodyType == "SCOOTER")
            {
                seatsNumber = 2;
            }
            if (bodyType == "ENDURO")
            {
                seatsNumber = 1;
            }

            return seatsNumber;
        }

        public string setColour(string _color)
        {
            bikeColor = _color;
            return bikeColor;
        }

        public int setEngine(int _engineDisplacement, string _transmission) //HARD TO TEST IT
        {
            engineDisplacement = _engineDisplacement;

            double randomPetrol = 5.5;
            
                engineKW = Convert.ToInt32(_engineDisplacement / (randomPetrol*1.34));
            

            transmission = _transmission;

            if (transmission == "AUTOMAT")
            {
                engineKW = Convert.ToInt32(engineKW * 0.9);
            }
            if (transmission == "MANUAL")
            {
                engineKW = Convert.ToInt32(engineKW / 0.8);
            }

            return engineKW;
        }

        public int setMillage(int _year)
        {
            year = _year;
            Random rnd = new Random();
            int randomMillage = rnd.Next(3000, 6000);
            int randomNewMillage = rnd.Next(0, 5000);

            if (year == 2020)
            {
                millage = randomNewMillage;
            }
            else
            {
                millage = (2020 - _year) * randomMillage;
            }

            return millage;
        }

        public List<string> addTurboGenerator()
        {
            additionalEquipment.Add("Turbo Kit");
            isOnAdditionalEquipment = true;

            return additionalEquipment;
        }

        public List<string> addAndroidMultimedia()
        {
            additionalEquipment.Add("Anti-wheelie system");
            isOnAdditionalEquipment = true;

            return additionalEquipment;
        }

        public List<string> addAutoClutch()
        {
            additionalEquipment.Add("Auto clutch");
            isOnAdditionalEquipment = true;

            return additionalEquipment;
        }
        public List<string> addABS()
        {
            additionalEquipment.Add("ABS");
            isOnAdditionalEquipment = true;

            return additionalEquipment;
        }

        public string setDrivingLicenseCategory(int _engineKW)
        {
            engineKW = _engineKW;
            if (engineKW <= 11)
            {
                drivingLicenseCategory = "A2";
            }
            if (engineKW > 11 && engineKW <= 35)
            {
                drivingLicenseCategory = "A1";
            }
            if (engineKW > 35)
            {
                drivingLicenseCategory = "A";
            }

            return drivingLicenseCategory;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Your new {0} bike have: {1} HP\nYear is: {2}\nColor is: {3}\nMillage is: {4}\nTransmission is: {5}\nBody type is: {6}\nSeats number is: {7}\nEngine Displacement is: {8} " +
                              "CC \nAnd a price special for you: {9}$\n\n", bikeMake, engineKW, year, bikeColor, millage, transmission, bodyType, seatsNumber, engineDisplacement, price);

            if (isOnAdditionalEquipment == true)
            {
                Console.WriteLine("Also you wanted special equipment on bike:");
                foreach (var item in additionalEquipment)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("For driving this motorbike you have to have driving license category: {0}", drivingLicenseCategory);
        }
    }
}
