using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Abstraction.Result;
using ConnectionProvider.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Managers.ExchangeRateManagers
{
    public interface IExchangeRateManager : IBaseManager
    {
        Task<Response<ExchangeRateDto>> GetExchangeRates(string currencyCode);
    }
}
