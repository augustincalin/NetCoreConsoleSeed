using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleSeedApp
{
    public class SomeService : ISomeService
    {
        private readonly ILogger<SomeService> _logger;
        public SomeService(ILogger<SomeService> logger)
        {
            _logger = logger;
        }

        public void DoSomething(string value)
        {
            _logger.LogInformation($"Do something from {value}.");
        }
    }
}
