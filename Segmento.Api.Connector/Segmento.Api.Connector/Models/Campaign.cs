using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Кампания
    /// </summary>
    public class Campaign
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

        /// <summary>
        /// Подкампании
        /// </summary>
        [JsonProperty("subcampaings")]
        public SubCampaign[] SubCampaigns { get; set; }

        #endregion
    }
}
