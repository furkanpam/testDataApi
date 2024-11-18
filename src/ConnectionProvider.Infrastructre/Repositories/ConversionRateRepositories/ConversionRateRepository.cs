using ConnectionProvider.Abstraction.Data.Context;
using ConnectionProvider.Core.Data.Repository;
using ConnectionProvider.Domain.Contexts;
using ConnectionProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Infrastructre.Repositories.ConversionRateRepositories
{
    public class ConversionRateRepository : EntityRepository<ConversionRate>, IConversionRateRepository
    {
        public ConversionRateRepository(ConnectionProviderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
