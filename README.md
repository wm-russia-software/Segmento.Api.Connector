# Segmento.Api.Connector
Library provides functionality for connecting and using methods to Segmento API.\
[Segmento](https://segmento.ru) is a Russian automated platform for purchasing ads in real-time auction format and target digital ads.

## Installation
Package is available at [nuget](https://www.nuget.org/packages/Segmento.Api.Connector). You can either use your favorite package manager or run 

```bash
Install-Package Segmento.Api.Connector -Version 1.0.3
```

## Usage

```c#
using Segmento.Api.Connector.Models;

// Obtaining authentification token
Token token = new Authentication().GetToken(yourLogin, yourPassword);

// Getting clients list
List<Client> clients = new Clients(token.AccessToken).GetClients();
// Getting campaigns list
List<Campaign> campaigns = new Campaigns(token.AccessToken).GetCampaigns(clientId);
// Getting statistics report
List<StatisticsItem> s = new Statistics(token.AccessToken).GetStatisticsReport(campaignId, startDate, endData);
```

For full classes and methods description take a look at our [documentation](https://github.com/wm-russia-software/Segmento.Api.Connector/wiki) (right now it is available only in Russian).

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://choosealicense.com/licenses/mit/)
