using TelephoneDirectory.DbModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace TelephoneDirectory.DbModel
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("PostgreSqlConnectionString");
            optionsBuilder.UseNpgsql(connectionString);
        }

      
        public DbSet<PersonEntities> Persons { get; set; } //Entities kısımları düzelt
        public DbSet<DetailEntities>Details { get; set; }
        public DbSet<TypeEntity>TypeEntities { get; set; }



    }
}
