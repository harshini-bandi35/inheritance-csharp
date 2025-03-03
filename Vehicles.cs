/*Modify the `DisplayInfo()` method in `Vehicle` to
 * print `Brand` and `Speed`. Override this method in
 * `Car` and `Bike` to include additional specific information.
 * Ensure the base class method is called using `base.DisplayInfo()`.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    public class Vehicles
    {
        public string Brand;
        public int Speed;
        public virtual void DisplayInfo(string brand,int speed)
        {
            Brand = brand;
            Speed = speed;

        }

    }
    public class Cars : Vehicles
    {
     
        public override void DisplayInfo(string brand,int speed)
        {
            base.DisplayInfo(brand, speed);
            Console.WriteLine($"the brand of the car is {brand} and speed is {speed}");
            
            
        }
    }
    public class Bikes : Vehicles
    {
        
        public override void DisplayInfo(string brand, int speed)
        {
            base.DisplayInfo(brand, speed);
            Console.WriteLine($"the brand of the bike is {brand} and number of wheels are {speed}");


        }
    }

}
