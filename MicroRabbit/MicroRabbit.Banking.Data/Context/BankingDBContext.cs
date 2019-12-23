using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDBContext : DbContext
    {
        public BankingDBContext()
        { }

        public BankingDBContext(DbContextOptions<BankingDBContext> options) : base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer("Server=MSSQLLocalDB;Database=BankingDB;MultipleActiveResultSets=True;");
            builder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = BankingDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            base.OnConfiguring(builder);
        }

        public DbSet<Account> Accounts { get; set; }

    }
}
