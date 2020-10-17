using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_in_class
{
    class Car : Vehicle
    {
        string maker;
        int year;
        string model;
        string trimLevel;
        string vehClass;

        public string getMaker()
        {
            return maker;
        }
        public int getYear()
        {
            return year;
        }
        public string getModel()
        {
            return model;
        }
        public string getTrimLevel()
        {
            return trimLevel;
        }
        public string getVehClass()
        {
            return vehClass;
        }
        public Car() : base()
        {
            maker = "";
            year = 2010;
            model = "";
            trimLevel = "";
            vehClass = "";
        }
        public Car(float registration_number, string colr, string makr, int yr, string modl, string trimLev, string vClass) : base(registration_number, colr)
        {
            maker = makr;
            year = yr;
            model = modl;
            trimLevel = trimLev;
            vehClass = vClass;
        }
    } // end of class Car
}
