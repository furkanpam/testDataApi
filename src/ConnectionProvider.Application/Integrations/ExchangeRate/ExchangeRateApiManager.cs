using Asis.Framework.Integration.Configurations;
using ConnectionProvider.Abstraction.Contracts.Dtos.Integrations;
using ConnectionProvider.Abstraction.Enums;
using ConnectionProvider.Abstraction.Exceptions;
using ConnectionProvider.Abstraction.Settings;
using ConnectionProvider.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Integrations.ExchangeRate
{
    public class ExchangeRateApiManager : IntegrationManagerBase , IExchangeRateApiManager
    {
        private CPHttpClientSettings? clientProperty;
        private string cpClientName = HttpClients.ExchangeRateApi.ToString();

        public ExchangeRateApiManager()
        {
            this.clientName = cpClientName;
            var clientConfigurtion = AppSettingsHelper.GetData<CPHttpClientConfiguration>();
            client = clientConfigurtion.HttpClients.FirstOrDefault(w => w.Name == clientName);
        }

        private CPHttpClientSettings client
        {
            get
            {
                if (clientProperty == null)
                    throw new BusinessException((int)HttpStatusCode.BadRequest, "Http Client Setting Not Found!");
                return clientProperty;
            }
            set
            {
                if (value == null)
                    throw new BusinessException((int)HttpStatusCode.BadRequest, "Http Client Setting Not Found!");
                clientProperty = value;
            }
        }

        public async Task<ExchangeRateDto> GetExchangeRate(string currencyCode)
        {
            var endPoint = client.EndPoints.FirstOrDefault(w => w.Name == nameof(EndPoints.GetExchangeRate));
            string url = endPoint.Url
                .Replace("@apiKey", client.SecurityKey)
                .Replace("@baseCurrency", currencyCode);
            var result = await SendToIntegrationAsync<ExchangeRateDto, ExchangeRateDto>(IntegrationSendTypes.Get, url);
            return result;
        }
    }
}
