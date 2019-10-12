using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSeedApp
{
    public class ConsoleApplication
    {
        private readonly ISomeService _someService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ConsoleApplication> _logger;

        public ConsoleApplication(ISomeService someService, IConfiguration configuration, ILogger<ConsoleApplication> logger)
        {
            _someService = someService;
            _configuration = configuration;
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation("Run started");
            _someService.DoSomething(_configuration.GetValue<string>("Location"));
        }
    }
}
