using System.Threading.Tasks;
using RestSharp;

namespace Segmento.Api.Connector
{
    /// <summary>
    /// Базовый обработчик API
    /// </summary>
    public abstract class BaseApiHandler
    {
        #region Переменные и константы

        /// <summary>
        /// Url для доступа к Api
        /// </summary>
        private const string CommonApiUrl = "https://api-my.segmento.ru";

        /// <summary>
        /// Таймаут между запросами
        /// </summary>
        protected const int DefaultRequestTimeout = 1100;

        #endregion

        #region Свойства

        /// <summary>
        /// Url для доступа к Api
        /// </summary>
        public string ApiUrl { get; }

        /// <summary>
        /// Таймаут между запросами
        /// </summary>
        public int RequestTimeout { get; set; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        protected BaseApiHandler()
        {
            ApiUrl = CommonApiUrl;
            RequestTimeout = DefaultRequestTimeout;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        protected BaseApiHandler(string apiUrl)
        {
            ApiUrl = apiUrl;
            RequestTimeout = DefaultRequestTimeout;
        }

        #endregion

        #region Защищенные методы

        /// <summary>
        /// Добавление заголовков запроса по умолчанию
        /// </summary>
        /// <param name="request">Запроса</param>
        protected virtual void AddDefaultHeaders(RestRequest request)
        {
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "x-www-form-urlencoded");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
        }

        /// <summary>
        /// Ожидание
        /// </summary>
        protected void Wait()
        {
            Task.Delay(RequestTimeout).Wait();
        }

        #endregion
    }
}
