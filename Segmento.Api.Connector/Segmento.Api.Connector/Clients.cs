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
    ///  Класс для работы с клиентами
    /// </summary>
    /// <seealso cref="BaseTokenApiHandler" />
    public class Clients : BaseTokenApiHandler
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="token">Токен</param>
        public Clients(string token) : base(token)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        /// <param name="token">Токен</param>
        public Clients(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Получение списка клиентов
        /// </summary>
        /// <returns></returns>
        public List<Client> GetClients()
        {
            string url = UrlHelper.CombineUrls(ApiUrl, @"api/v1/clients");
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(Method.GET);
            AddDefaultHeaders(request);

            IRestResponse response = client.Execute(request);
            Wait();
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<DataContainer<Client>>(response.Content).Values.ToListEx();
            else
                throw new HttpRequestException($"Не удалось получить список клиентов. Код ответа: {response.StatusCode}");
        }

        #endregion
    }
}
