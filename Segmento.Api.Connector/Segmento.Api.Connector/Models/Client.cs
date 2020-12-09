using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client
    {
        #region Свойства

        /// <summary>
        /// Идентификатор
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        #endregion
    }
}
