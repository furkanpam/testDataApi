using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Integrations.ExchangeRate
{
    public interface IExchangeRateApiManager : IBaseManager
    {
        Task<ExchangeRateDto> GetExchangeRate(string currencyCode);
    }
}
