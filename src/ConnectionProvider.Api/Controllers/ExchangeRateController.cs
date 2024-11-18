using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Abstraction.Result;
using ConnectionProvider.Application.Managers.ExchangeRateManagers;
using ConnectionProvider.Core.Controller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConnectionProvider.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ApiControllerBase
    {
        private readonly IExchangeRateManager exchangeRateManager;

        public ExchangeRateController(IExchangeRateManager exchangeRateManager)
        {
            this.exchangeRateManager = exchangeRateManager;
        }
        [HttpGet("[Action]")]
        public async Task<Response<ExchangeRateDto>> GetExchangeRate([FromQuery]string currencyCode)
        {
            var response = await exchangeRateManager.GetExchangeRates(currencyCode);
            return response;
        }
    }
}
