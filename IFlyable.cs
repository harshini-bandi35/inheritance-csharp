/*7. Multiple Inheritance Using Interfaces
Time: 15 mins
Create two interfaces `IFlyable` and `ISwimmable` with methods
`Fly()` and `Swim()`, respectively. Implement these interfaces
in a class `Duck` to exhibit both behaviors.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    interface IFlyable
    {
        abstract void Fly();
    }
    interface ISwimmable
    {
        abstract void Swim();
    }
    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
        public void Swim()
        {
            Console.WriteLine("Duck is swimming");
        }
    }
    
}
