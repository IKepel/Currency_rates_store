using Currency_rates_store;
using Newtonsoft.Json;

using var myDb = new AppDbContext();
var privatUri = new Uri("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
using var client = new HttpClient();
using HttpResponseMessage response = await client.GetAsync(privatUri);

var content = await response.Content.ReadAsStringAsync();

var currencyRates = JsonConvert.DeserializeObject<List<CurrencyRate>>(content);
if (currencyRates != null)
{
    foreach (var rate in currencyRates)
    {
        myDb.CurrencyRates.Add(rate);
    }
    await myDb.SaveChangesAsync();
    Console.WriteLine("The data is successfully saved to the database.");
}
else Console.WriteLine("The data is not saved to the database.");