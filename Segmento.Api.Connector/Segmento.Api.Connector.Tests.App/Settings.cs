using System.Configuration;
using Ak.Framework.Core.Extensions;

namespace Segmento.Api.Connector.Tests.App
{
    /// <summary>
    /// Настройки
    /// </summary>
    internal class Settings
    {
        #region Свойства

        /// <summary>
        /// Логин для доступа к Segmento API
        /// </summary>
        public static string SegmentoLogin => ConfigurationManager.AppSettings["SegmentoLogin"].ToStr();

        /// <summary>
        /// Пароль для доступа к Segmento API
        /// </summary>
        public static string SegmentoPassword => ConfigurationManager.AppSettings["SegmentoPassword"].ToStr();

        #endregion
    }
}
