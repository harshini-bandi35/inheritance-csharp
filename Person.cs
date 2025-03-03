/*Upcasting and Downcasting
Time: 15 mins
Create a base class `Person` and derive a class `Student`.
Create an object of `Student`, upcast it to `Person`, and 
then downcast it back to `Student`. Demonstrate how type casting works.
*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("engineering");
        }
    }
}
