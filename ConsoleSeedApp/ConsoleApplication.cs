using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSeedApp
{
    public class ConsoleApplication
    {
        private readonly ISomeService _someService;

        public ConsoleApplication(ISomeService someService)
        {
            _someService = someService;
        }

        public void Run()
        {
            _someService.DoSomething();
        }
    }
}
