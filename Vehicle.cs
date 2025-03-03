/*Create a base class `Vehicle` with properties `Brand` and `Speed`. 
 * Derive two classes `Car` and `Bike` from `Vehicle`. Add a method `DisplayInfo()`
 * in `Vehicle` that should be accessible in the derived classes.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    public class Vehicle
    {
        public string Brand;
        public int Speed;
        public void DisplayInfo(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
            Console.WriteLine($"the brand of vehicle is {brand} and speed is {speed}");
        }


    }
    public class Car : Vehicle { 
    
        public  void CarMethod() {
           
            Console.WriteLine("this is the child class car");
        }

    }
    public class Bike : Vehicle
    {
        public void BikeMethod()
        {
            
            Console.WriteLine("This is the child class Bike");
        }
    }
}

