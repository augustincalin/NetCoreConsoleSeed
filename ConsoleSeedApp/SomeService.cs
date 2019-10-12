using ConsoleSeedApp.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleSeedApp
{
    public class SomeService : ISomeService
    {
        private readonly ILogger<SomeService> _logger;
        private readonly SomeDbContext _context;

        public SomeService(ILogger<SomeService> logger, SomeDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void DoSomething(string value)
        {
            _logger.LogInformation($"Do something from {value}.");
            _logger.LogInformation(_context.SampleEntities.Select(s => s.Name).ToList().Aggregate(string.Empty, (current, next) => current + ", " + next));
        }
    }
}
