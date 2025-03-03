/*Create an abstract class `Animal` with an abstract method `MakeSound()`.
 * Derive two classes `Dog` and `Cat` that override `MakeSound()`.
 * Instantiate objects of both classes and call the method.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    public abstract class Animal
    {
        public abstract void MakeSound();

    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark Bark");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }

}
