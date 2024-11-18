using ConnectionProvider.Abstraction.Data.EfCore.Repository;
using ConnectionProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Infrastructre.Repositories.ExchangeRateRepositories
{
    public interface IExchangeRateRepository : IRepository<ExchangeRate>
    {
    }
}
