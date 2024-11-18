using ConnectionProvider.Abstraction.Data.Context;
using ConnectionProvider.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Domain.Contexts
{
    public partial class ConnectionProviderDbContext : DbContextBase
    {
        public ConnectionProviderDbContext()
        {
            
        }

        public ConnectionProviderDbContext([NotNull] DbContextOptions<ConnectionProviderDbContext> options) : base(options)
        {
            
        }

        #region DbSets
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; } = null;
        public virtual DbSet<ConversionRate> ConversionRates { get; set; } = null;
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
