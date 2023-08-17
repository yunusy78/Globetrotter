using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Web.Areas.Admin.Models;

namespace Web.Areas.Admin.Controllers;
[Area("Admin")]
public class VisitorApiController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    
    public VisitorApiController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("http://localhost:5096/api/Visitor");
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var visitors = JsonConvert.DeserializeObject<List<VisitorViewModel>>(responseContent);
            return View(visitors);
        }
        else
        {
            return NotFound();
        }
            
    }
    
       public IActionResult Add()
        {
            return View();
        }
    
   
    
    [HttpPost]
    public async Task<IActionResult> Add(VisitorViewModel visitor)
    {
        visitor.IsCheckedOut = false;
        var client = _httpClientFactory.CreateClient();
        var json = JsonConvert.SerializeObject(visitor);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("http://localhost:5096/api/Visitor", data);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }
    
    public async Task<IActionResult> Update(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync($"http://localhost:5096/api/Visitor/{id}");
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var visitor = JsonConvert.DeserializeObject<VisitorViewModel>(responseContent);
            return View(visitor);
        }
        else
        {
            return NotFound();
        }
    }
    
    [HttpPost]
    
   public async Task<IActionResult> Update(VisitorViewModel visitor)
    {
        var client = _httpClientFactory.CreateClient();
        var json = JsonConvert.SerializeObject(visitor);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("http://localhost:5096/api/Visitor", data);
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }
   
   
   public async Task<IActionResult> Delete(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.DeleteAsync($"http://localhost:5096/api/Visitor/{id}");
        if (response.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return NotFound();
        }
    }
    
}