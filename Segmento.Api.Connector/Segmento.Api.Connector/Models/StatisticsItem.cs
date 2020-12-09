using System;
using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Элемент статистики
    /// </summary>
    public class StatisticsItem
    {
        #region Свойства

        /// <summary>
        /// Дата
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Количество показов 
        /// </summary>
        [JsonProperty("impressions")]
        public int? Impressions { get; set; }

        /// <summary>
        /// Количество видимых показов
        /// </summary>
        [JsonProperty("viewableImpressions")]
        public int? ViewableImpressions { get; set; }

        /// <summary>
        /// Количество кликов
        /// </summary>
        [JsonProperty("clicks")]
        public int? Clicks { get; set; }

        /// <summary>
        /// Количество post-click конверсий
        /// </summary>
        [JsonProperty("postClicks")]
        public int? PostClicks { get; set; }

        /// <summary>
        /// Количество last-click конверсий
        /// </summary>
        [JsonProperty("lastClicks")]
        public int? LastClicks { get; set; }

        /// <summary>
        /// Количество post-view конверсий совершенных после просмотра рекламы до 30 дней до совершения конверсии
        /// </summary>
        [JsonProperty("postViews30")]
        public int? PostViews30Days { get; set; }

        /// <summary>
        /// Количество post-view конверсий совершенных после просмотра рекламы до 3 дней до совершения конверсии
        /// </summary>
        [JsonProperty("postViews3")]
        public int? PostViews3Days { get; set; }

        /// <summary>
        /// Количество сессий
        /// </summary>
        [JsonProperty("sessions")]
        public int? Sessions { get; set; }

        /// <summary>
        /// Количество сессий после просмотра рекламы
        /// </summary>
        [JsonProperty("postViewSessions")]
        public int? PostViewSessions { get; set; }

        /// <summary>
        /// Количество уникальных пользователей после просмотра рекламы 
        /// </summary>
        [JsonProperty("postViewVisitors")]
        public int? PostViewVisitors { get; set; }

        /// <summary>
        /// Количество досмотров видео 
        /// </summary>
        [JsonProperty("videoComplete")]
        public int? VideoComplete { get; set; }

        /// <summary>
        /// Стоимость для клиента 
        /// </summary>
        [JsonProperty("clientCost")]
        public decimal? ClientCost { get; set; }

        /// <summary>
        /// Время на сайте
        /// </summary>
        [JsonProperty("meanDuration")]
        public decimal? MeanDuration { get; set; }

        /// <summary>
        /// Глубина просмотра
        /// </summary>
        [JsonProperty("pageDepth")]
        public decimal? PageDepth { get; set; }

        /// <summary>
        /// Время на сайте
        /// </summary>
        [JsonProperty("bounceRate")]
        public decimal? BounceRate { get; set; }

        #endregion
    }
}
