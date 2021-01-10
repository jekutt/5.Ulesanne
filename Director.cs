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
            this._bike.addTurboGenerator();
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
            this._bike.addAndroidMultimedia();
            this._bike.GetPrice();
            this._bike.PrintInfo();

            return this._bike.price;
        }
    }
}
