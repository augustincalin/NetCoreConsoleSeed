using ConsoleSeedApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSeedApp.Data
{
    public class SomeDbContext : DbContext
    {
        public DbSet<SampleEntity> SampleEntities { get; set; }

        public SomeDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
