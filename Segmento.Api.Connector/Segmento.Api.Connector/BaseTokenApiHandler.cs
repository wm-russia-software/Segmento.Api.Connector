using RestSharp;

namespace Segmento.Api.Connector
{
    /// <summary>
    /// Базовый обработчик API
    /// </summary>
    public abstract class BaseTokenApiHandler : BaseApiHandler
    {
        #region Свойства

        /// <summary>
        /// Токен
        /// </summary>
        public string Token { get; }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="token">Токен</param>
        protected BaseTokenApiHandler(string token)
        {
            Token = token;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="apiUrl">Url для доступа к Api</param>
        /// <param name="token">Токен</param>
        protected BaseTokenApiHandler(string apiUrl, string token) : base(apiUrl)
        {
            Token = token;
        }

        #endregion

        #region Защищенные методы

        /// <summary>
        /// Добавление заголовков запроса по умолчанию
        /// </summary>
        /// <param name="request">Запрос</param>
        protected override void AddDefaultHeaders(RestRequest request)
        {
            request.AddHeader("Authorization", $"Bearer {Token}");
        }

        #endregion
    }
}
