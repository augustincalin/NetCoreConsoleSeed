using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSeedApp
{
    public class ConsoleApplication
    {
        private readonly ISomeService _someService;
        private readonly IConfiguration _configuration;

        public ConsoleApplication(ISomeService someService, IConfiguration configuration)
        {
            _someService = someService;
            _configuration = configuration;
        }

        public void Run()
        {
            _someService.DoSomething(_configuration.GetSection("Location").Value);
        }
    }
}
