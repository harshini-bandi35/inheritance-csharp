/*6. Sealed Class and Methods
Time: 12 mins
Create a base class `Account` with a virtual method
`CalculateInterest()`. Derive a class `SavingsAccount`
and override `CalculateInterest()`. Now, prevent further
overriding by marking it as `sealed`.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceone
{
    public class Account
    {
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Interest calculator");
        }

    }
    public class SavingsAccount:Account
    {
        public sealed override void CalculateInterest()
        {
            Console.WriteLine("this is the sealed method calculate interest");
        }
    }
    //public class CurrentAccount:SavingsAccount gets error in this case because
    //we cannot use the method that is sealed in the base class
    public class CurrentAccount : Account//instead we can do this to stop the occurence of error.
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("this is current account");
        }
    }
}
