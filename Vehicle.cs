using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP_in_class
{
    class Vehicle
    {
        // the following syntax does not work because the variable must be public for the get/set to work
        // on the anonymous backing variable
        // protected string color { get; set; }
        protected string color;
        protected float registration_number; 
        protected Person owner = new Person();
        public float getRegNum()
        {
            return registration_number;
        }
        public void setRegNum(float rnum)
        {
            registration_number = rnum;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string colr)
        {
            color = colr;
        }
        public string getOwner()
        {
            return owner.fullName;
        }
        public void SetOwner(string name)
        {
            owner.fullName = name;
        }
        protected Vehicle()
        {
            registration_number = 10;
            color = "";
        }
        protected Vehicle(float regNum, string colr)
        {
            registration_number = regNum;
            color = colr;
        }
    } // end of class Vehicle
}
