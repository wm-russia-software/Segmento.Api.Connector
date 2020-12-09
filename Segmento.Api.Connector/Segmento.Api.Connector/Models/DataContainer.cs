using System.Collections.Generic;
using Newtonsoft.Json;

namespace Segmento.Api.Connector.Models
{
    /// <summary>
    /// Контейнер данных
    /// </summary>
    internal class DataContainer<T>
    {
        #region Свойства

        /// <summary>
        /// Элементы
        /// </summary>
        [JsonProperty("values")]
        public List<T> Values { get; set; }

        #endregion
    }
}
