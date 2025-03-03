/*Interface vs Inheritance in C#
Time: 15 mins
Create an interface
`IMovable` with a method `Move()`. 
Implement this interface in a `Robot` class.
Also, create a base class `Machine` with a method `Start()`.
Have `Robot` inherit from `Machine` and implement `IMovable`.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    interface IMovable
    {
        abstract void Move();
    }
    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine was started");
        }
    }
    public class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving");
        }
    }
}
