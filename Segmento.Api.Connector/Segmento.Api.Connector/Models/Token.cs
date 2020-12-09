using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Токен
    /// </summary>
    public class Token
    {
        #region Свойства

        /// <summary>
        /// Токен доступа
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Тип токена
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Время жизни
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiringTime { get; set; }

        #endregion
    }
}
