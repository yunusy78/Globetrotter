using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class ImdbMovieApiController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
            Headers =
            {
                { "X-RapidAPI-Key", "fe7290ac1fmsh84db888713fb8ecp1be836jsn85b6364450f1" },
                { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            List<MovieViewModel> movies = JsonConvert.DeserializeObject<List<MovieViewModel>>(body)!;
            Console.WriteLine(movies);
            return View(movies);
        }

        return View();
    }
}