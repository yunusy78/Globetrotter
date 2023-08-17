using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        var date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        _logger.LogInformation("Index sayfasına giriş yapıldı."+date);
        _logger.LogError("Error"+date);
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogInformation("Privacy sayfasına giriş yapıldı.");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    public IActionResult Test()
    {
        _logger.LogInformation("Test sayfasına giriş yapıldı.");
        return View();
    }
}

