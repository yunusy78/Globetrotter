using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class ExchangeRateController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have=EUR&want=NOK&amount=1"),
            Headers =
            {
                { "X-RapidAPI-Key", "fe7290ac1fmsh84db888713fb8ecp1be836jsn85b6364450f1" },
                { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            ExchangeRate exchangeRate = JsonConvert.DeserializeObject<ExchangeRate>(body)!;
            Console.WriteLine(exchangeRate);
            return View(exchangeRate);
        }
       
    }
    
    
    [HttpPost]
    public async Task<IActionResult> Index(string haveCurrency, string wantCurrency, decimal amount)
    {
        var baseUrl = "https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency";
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"{baseUrl}?have={haveCurrency}&want={wantCurrency}&amount={amount}"),
            Headers =
            {
                { "X-RapidAPI-Key", "fe7290ac1fmsh84db888713fb8ecp1be836jsn85b6364450f1" },
                { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
            },
        };

        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            ExchangeRate exchangeRate = JsonConvert.DeserializeObject<ExchangeRate>(body);
            Console.WriteLine(exchangeRate);
            return View(exchangeRate);
        }
    }

}

