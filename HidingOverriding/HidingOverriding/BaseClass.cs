﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HidingOverriding
{
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base-Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }

    }
}
