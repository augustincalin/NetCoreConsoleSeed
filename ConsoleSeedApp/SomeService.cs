using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleSeedApp
{
    public class SomeService : ISomeService
    {
        public void DoSomething(string value)
        {
            Debug.WriteLine($"Do something from {value}.");
        }
    }
}
