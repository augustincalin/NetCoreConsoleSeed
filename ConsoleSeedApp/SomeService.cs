using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleSeedApp
{
    public class SomeService : ISomeService
    {
        public void DoSomething()
        {
            Debug.WriteLine("Do something...");
        }
    }
}
