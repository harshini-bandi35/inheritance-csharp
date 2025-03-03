/*Create a `sealed` class `SecuritySystem`
 * with a method `AuthenticateUser()`. 
 * Try to derive a class from it and observe 
 * the compiler error. Explain why `sealed` is
 * useful in real-world applications.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    public sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("User authenticated successfully.");
        }
    }

    // Try to derive a class from SecuritySystem
    /*public class AdvancedSecuritySystem : SecuritySystem
    {
        // This will cause a compiler error..because you cannot derive a class from sealed class
        //sealed means which is closed and secured cannot be used by others...can only be 
        //used by the owners so using the sealed method in the derived class and 
        //deriving a class from the sealed class is not possible.these causes errors
    }*/
}
