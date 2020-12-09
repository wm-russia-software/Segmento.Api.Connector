using System;
using System.Collections.Generic;
using Segmento.Api.Connector.Models;

namespace Segmento.Api.Connector.Tests.App
{
    /// <summary>
    /// Программа
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
            Token token = new Authentication().GetToken(Settings.SegmentoLogin, Settings.SegmentoPassword);
            List<Client> clients = new Clients(token.AccessToken).GetClients();
            
            //List<Campaign> campaigns = new Campaigns(token.AccessToken).GetCampaigns(clientId);
            //List<StatisticsItem> s = new Statistics(token.AccessToken).GetStatisticsReport(campaignId, startDate, endData);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
