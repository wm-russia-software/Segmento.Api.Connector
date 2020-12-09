using System;
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
    ///  Класс для получения статистических отчетов
    /// </summary>
    /// <seealso cref="BaseTokenApiHandler" />
    public class Statistics : BaseTokenApiHandler
    {
        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="token">Токен</param>
        public Statistics(string token) : base(token)
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        /// <param name="token">Токен</param>
        public Statistics(string apiUrl, string token) : base(apiUrl, token)
        {
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Получение основного статистического отчета
        /// </summary>
        /// <param name="campaignId">Идентификатор кампании</param>
        /// <param name="startDate">Начальная дата</param>
        /// <param name="endDate">Конечная дата</param>
        /// <returns></returns>
        public List<StatisticsItem> GetStatisticsReport(int campaignId, DateTime startDate, DateTime endDate)
        {
            string url = UrlHelper.CombineUrls(ApiUrl, $@"api/v1/statistics/{campaignId}/days?from={startDate:yyyy-MM-dd}&to={endDate:yyyy-MM-dd}");
            RestClient client = new RestClient(url) { Timeout = -1 };
            RestRequest request = new RestRequest(Method.GET);
            AddDefaultHeaders(request);

            IRestResponse response = client.Execute(request);
            Wait();
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<DataContainer<StatisticsItem>>(response.Content).Values.ToListEx();
            else
                throw new HttpRequestException($"Не удалось получить основной статистический отчет. Код ответа: {response.StatusCode}");
        }

        #endregion
    }
}
