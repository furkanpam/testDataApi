using AutoMapper;
using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Abstraction.Result;
using ConnectionProvider.Application.Integrations.ExchangeRate;
using ConnectionProvider.Domain.Entities;
using ConnectionProvider.Infrastructre.Repositories.ExchangeRateRepositories;
using ConnectionProvider.Infrastructre.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Managers.ExchangeRateManagers
{
    public class ExchangeRateManager : IExchangeRateManager
    {
        private readonly IExchangeRateApiManager exchangeRateApiManager;
        private readonly IExchangeRateRepository exchangeRateRepository;
        private readonly ICPUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public ExchangeRateManager(IExchangeRateApiManager exchangeRateApiManager,
                                   IExchangeRateRepository exchangeRateRepository,
                                   ICPUnitOfWork unitOfWork,
                                   IMapper mapper)
        {
            this.exchangeRateApiManager = exchangeRateApiManager;
            this.exchangeRateRepository = exchangeRateRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<Response<ExchangeRateDto>> GetExchangeRates(string currencyCode)
        {
            var exchaneRate = await exchangeRateApiManager.GetExchangeRate(currencyCode);
            var exchangeRateEntity = new ExchangeRate
            {
                base_code = exchaneRate.base_code,
                documentation = exchaneRate.documentation,
                result = exchaneRate.result,
                terms_of_use = exchaneRate.terms_of_use,
                time_last_update_unix = exchaneRate.time_last_update_unix,
                time_last_update_utc = exchaneRate.time_last_update_utc,
                time_next_update_unix = exchaneRate.time_next_update_unix,
                time_next_update_utc = exchaneRate.time_next_update_utc,
                ConversionRates = mapper.Map<ConversionRate>(exchaneRate.conversion_rates)
            };

            await exchangeRateRepository.AddAsync(exchangeRateEntity);
            await unitOfWork.SaveChangesAsync();

            return Response<ExchangeRateDto>.Success(exchaneRate);
        }
    }
}
