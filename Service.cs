using System.Net.Http;
using System.Threading.Tasks;

class ApiService
{
    public async Task<Root> GetBitcoinPrice()
    {
        var client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://api.coindesk.com/v1/bpi/currentprice.json");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        Root result = JsonConvert.DeserializeObject<Root>(responseBody);
        return result;
    }
}


