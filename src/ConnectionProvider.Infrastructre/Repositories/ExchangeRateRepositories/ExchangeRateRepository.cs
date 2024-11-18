using ConnectionProvider.Abstraction.Attributes;
using ConnectionProvider.Abstraction.Data.Context;
using ConnectionProvider.Abstraction.Enums;
using ConnectionProvider.Core.Data.Repository;
using ConnectionProvider.Domain.Contexts;
using ConnectionProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Infrastructre.Repositories.ExchangeRateRepositories
{
    [LifeCircle(LifeCircleTypes.Scoped)]
    public class ExchangeRateRepository : EntityRepository<ExchangeRate>, IExchangeRateRepository
    {
        public ExchangeRateRepository(ConnectionProviderDbContext dbContext) : base(dbContext)
        {
        }
    }
}
