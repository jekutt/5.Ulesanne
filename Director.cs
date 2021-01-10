using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Ulesanne
{
    public class Director
    {
        private IBike _bike;

        public IBike Bike
        {
            set { _bike = value; }
        }

        public int constructSportBike()
        {
            Console.WriteLine("You Choose Auto-Generated: Sport Bike\n");
            this._bike.bikeMake = "BMW";
            this._bike.setBodyType("SPORT");
            this._bike.setColour("RED");
            this._bike.setEngine(1500, "MANUAL");
            this._bike.setMillage(2019);
            this._bike.addABS();
            this._bike.addTurboCharge();
            this._bike.addAntiWheelie();
            this._bike.GetPrice();
            this._bike.PrintInfo();

            return this._bike.price;
        }

        public int constructTouringBike()
        {
            Console.WriteLine("You Choose Auto-Generated: Touring Bike\n");
            this._bike.bikeMake = "KAWASAKI";
            this._bike.setBodyType("TOURING");
            this._bike.setColour("WHITE");
            this._bike.setEngine(1200, "AUTOMAT");
            this._bike.setMillage(2016);
            this._bike.addABS();
            this._bike.addAntiWheelie();
            this._bike.GetPrice();
            this._bike.PrintInfo();

            return this._bike.price;
        }
        public int constructScooterBike()
        {
            Console.WriteLine("You Choose Auto-Generated: Scooter Bike\n");
            this._bike.bikeMake = "HONDA";
            this._bike.setBodyType("SCOOTER");
            this._bike.setColour("GREY");
            this._bike.setEngine(50, "AUTOMAT");
            this._bike.setMillage(2010);
            this._bike.GetPrice();
            this._bike.PrintInfo();

            return this._bike.price;
        }
        public int constructCustomBike()
        {
            Console.WriteLine("You Choose Auto-Generated: Custom Bike\n");
            this._bike.bikeMake = "YAMAHA";
            this._bike.setBodyType("STREET");
            this._bike.setColour("GREEN");
            this._bike.setEngine(998, "MANUAL");
            this._bike.setMillage(2014);
            this._bike.addABS();
            this._bike.addAutoClutch();
            this._bike.GetPrice();
            this._bike.PrintInfo();

            return this._bike.price;
        }
    }
}
