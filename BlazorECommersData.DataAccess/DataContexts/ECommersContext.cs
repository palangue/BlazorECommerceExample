using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorECommersData.DataAccess.DataContexts
{
    public class ECommersContext : DbContext
    {
        private readonly DbContextOptions<ECommersContext> options;
        private readonly IConfiguration config;

        public ECommersContext(DbContextOptions<ECommersContext> options, IConfiguration config) : base(options)
        {
            this.options = options;
            this.config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine(config.GetConnectionString("MariaDb"));
            optionsBuilder.UseMySql(config.GetConnectionString("MariaDb"), ServerVersion.AutoDetect(config.GetConnectionString("MariaDb")));
            
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Category>? Categories { get; set; }
    }
}

