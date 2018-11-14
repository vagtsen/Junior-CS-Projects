using System;
using System.Collections.Generic;
using System.Text;

namespace HidingOverriding
{
    class DerivedClass : BaseClass
    {
        public override void Method2()
        {
            Console.WriteLine("Derived- Method2");
        }
    }
}
