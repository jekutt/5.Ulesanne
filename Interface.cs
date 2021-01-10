using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Ulesanne
{
    public interface IBike
    {
        string bikeMake { get; set; }
        string bikeColor { get; set; }
        int engineKW { get; set; }
        double engineDisplacement { get; set; }
        int year { get; set; }
        int millage { get; set; }
        string transmission { get; set; }
        string bodyType { get; set; }
        int seatsNumber { get; set; }
        string drivingLicenseCategory { get; set; }
        int price { get; set; }

        void reset();
        int setEngine(int _engineDisplacement, string _transmission);
        string setColour(string _color);
        int setBodyType(string _bodyType);
        int setMillage(int _year);
        string setDrivingLicenseCategory(int _engineKW);
        List<string> addTurboCharge();
        List<string> addAntiWheelie();
        List<string> addAutoClutch();
        public List<string> addABS();
        int GetPrice();
        void PrintInfo();
    }
}
