using System;
using System.Diagnostics;
using System.Text;

namespace OOP_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type (car or bike) or press enter to change the owner:\n");
            string userVehType = Console.ReadLine();
            if (userVehType == "car")
            {
                // this is a better user experience but it takes more code
                Console.WriteLine("\nEnter the registration number:");
                string rNum = Console.ReadLine();
                Console.WriteLine("\nEnter the color:");
                string colr = Console.ReadLine();
                Console.WriteLine("\nEnter the maker:");
                string mak = Console.ReadLine();
                Console.WriteLine("\nEnter the four-digit year:");
                string yr = Console.ReadLine();
                Console.WriteLine("\nEnter the model:");
                string modl = Console.ReadLine();
                Console.WriteLine("\nEnter the trim level:");
                string trim = Console.ReadLine();
                Console.WriteLine("\nEnter the class:");
                string clas = Console.ReadLine();
                Car myCar = new Car(float.Parse(rNum), colr, mak, int.Parse(yr), modl, trim, clas);
                Console.WriteLine("\nI've always wanted a " + myCar.getColor() + " " + myCar.getMaker() + ".");
                Console.ReadKey();
            }
            else if (userVehType == "bike")
            {
                // this is a worse user experience but it takes less code
                Console.WriteLine("Enter registration number, color, maker, number of gears, class, and weight separated by space:\n");
                string bikeDetails = Console.ReadLine();
                string[] bDets = bikeDetails.Split(" ");
                Bike myBike = new Bike();
                try
                {
                    myBike = new Bike(float.Parse(bDets[0]), bDets[1], bDets[2], int.Parse(bDets[3]), bDets[4], float.Parse(bDets[5]));
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nError: " + e + "\n");
                }
                Console.WriteLine("\nI've always wanted a " + myBike.getColor() + " " + myBike.maker + ".");
                Console.ReadKey();
                myBike.maker = "Huffy"; // change maker
                Console.WriteLine("\nI've always wanted a " + myBike.getColor() + " " + myBike.maker + ".");
                Console.ReadKey();
            }
            else
            {
                Car myCar = new Car();
                Console.WriteLine("\n" + myCar.getOwner() + "\n"); 
                Console.WriteLine("Enter the new owner's first and last names:\n");
                string newOwner = Console.ReadLine();
                myCar.SetOwner(newOwner);
                Console.WriteLine("\n" + myCar.getOwner());
                Console.WriteLine("\n" + myCar.getRegNum()); // display default reg num value inherited from vehicle class
                Console.ReadKey();
            }
        }
    } // end of class Program
}
