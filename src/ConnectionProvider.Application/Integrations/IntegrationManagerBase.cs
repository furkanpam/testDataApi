using Asis.Framework.Integration.Factories;
using Asis.Framework.Integration.Helper;
using ConnectionProvider.Abstraction.Enums;
using ConnectionProvider.Core.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Application.Integrations
{
    public abstract class IntegrationManagerBase

    {
        private IHttpClientHelperFactory httpClientHelperFactory;
        protected string clientName = string.Empty;

        protected IntegrationManagerBase()
        {
            
        }

        protected async Task<TResponse> SendToIntegrationAsync<TResponse, TRequest>(IntegrationSendTypes sendTypes, string url, TRequest request = default, Dictionary<string, string> extraHeaders = null, TimeSpan? timeOut = null)
    where TResponse : class, new()
        {
            this.httpClientHelperFactory = new HttpClientHelperFactory(IntegrationHelper.CreateHttpClient(clientName));
            string responseMessage = string.Empty;
            DateTime requestDate = DateTime.Now;
            TResponse response = new TResponse();
            try
            {
                switch (sendTypes)
                {
                    case IntegrationSendTypes.Post:
                        response = await httpClientHelperFactory.PostAsync<TResponse, TRequest>(method: url, parameters: request, extraHeaders: extraHeaders, timeout: timeOut);
                        break;
                    case IntegrationSendTypes.Get:
                        response = await httpClientHelperFactory.GetAsync<TResponse>(method: url, extraHeaders: extraHeaders, timeout: timeOut);
                        break;
                    default:
                        responseMessage = "Undefined SendType";
                        break;
                }

                responseMessage = JsonConvert.SerializeObject(response);
            }
            catch (TaskCanceledException timeoutExp)
            {
                throw timeoutExp;
            }
            catch (Exception exp)
            {
                responseMessage = exp.GetAllInnerExceptionsAsJson();
            }

            return response;

        }
    }
}
