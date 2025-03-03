/*Create a base class `Product` with properties 
 * `Name` and `Price`. Derive two classes
 * `ElectronicProduct` and `ClothingProduct`. 
 * Add a `GetDiscountedPrice()` method in the base class
 * and override it in the derived classes to apply different discount rules.*/
using System;

namespace inheritanceone
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual void GetDiscountedPrice()
        {
            Console.WriteLine($"The name of the product is {Name} and the discount price is {Price - 20}");
        }
    }

    public class ElectronicProduct : Product
    {
        public override void GetDiscountedPrice()
        {
            Console.WriteLine($"The name of the electronic product is {Name} and the discount price is {Price - 50}");
        }
    }

    public class ClothingProduct : Product
    {
        public override void GetDiscountedPrice()
        {
            Console.WriteLine($"The name of the clothing product is {Name} and the discount price is {Price - 30}");
        }
    }
}