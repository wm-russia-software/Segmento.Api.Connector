using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Ak.Framework.Core.Extensions;
using Ak.Framework.Core.Helpers;
using Newtonsoft.Json;
using RestSharp;
using Segmento.Api.Connector.Models;

namespace Segmento.Api.Connector
{
    /// <summary>
    ///  Класс для работы с кампаниями
    /// </summary>
    /// <seealso cref="BaseTokenApiHandler" />
    public class Campaigns : BaseTokenApiHandler
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="token">Токен</param>
        public Campaigns(string token) : base(token)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        /// <param name="token">Токен</param>
        public Campaigns(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Получение списка кампаний
        /// </summary>
        /// <param name="clientId">Идентификатор клиента</param>
        /// <returns></returns>
        public List<Campaign> GetCampaigns(int clientId)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/v1/clients/{clientId}/campaigns");
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(Method.GET);
            AddDefaultHeaders(request);

            IRestResponse response = client.Execute(request);
            Wait();
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<DataContainer<Campaign>>(response.Content).Values.ToListEx();
            else
                throw new HttpRequestException($"Не удалось получить список кампаний. Код ответа: {response.StatusCode}");
        }

        #endregion
    }
}
