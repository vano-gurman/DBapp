using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace DataAccessLibrary.DataAccess
{
    public class ClientsContext : DbContext
    {
        public ClientsContext() : base() { }
        public ClientsContext(DbContextOptions options) : base(options) { }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Account>Accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["myDB"].ConnectionString);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=myDB;Trusted_Connection=True;");
        }
    }
}
