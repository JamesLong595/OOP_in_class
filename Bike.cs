using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_in_class
{
    class Bike : Vehicle
    {
        public string maker { get; set; }
        int numGears;
        string bikeClass;
        float weight;

        public int getNumGears()
        {
            return numGears;
        }
        public string getBikeClass()
        {
            return bikeClass;
        }
        public float getWeight()
        {
            return weight;
        }
        public Bike()
        { }
        public Bike(float reg_number, string color, string makr, int numGrs, string bClass, float wgt) : base()
        {
            registration_number = reg_number;
            this.color = color;
            maker = makr;
            numGears = numGrs;
            bikeClass = bClass;
            weight = wgt;
        }
    } // end of class Bike
}
