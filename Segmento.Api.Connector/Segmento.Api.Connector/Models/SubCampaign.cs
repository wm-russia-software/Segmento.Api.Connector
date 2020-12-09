using System;
using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Подкампания
    /// </summary>
    public class SubCampaign
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
        /// Начальная дата
        /// </summary>
        [JsonProperty("begin")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Конечная дата
        /// </summary>
        [JsonProperty("end")]
        public DateTime? EndDate { get; set; }

        #endregion
    }
}
