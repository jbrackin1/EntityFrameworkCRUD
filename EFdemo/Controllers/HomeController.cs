using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFdemo.Models;

namespace EFdemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult AddUsers()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddUsers(UserModel user)
    {
        using (var db = new DemoContext())
        {
            db.Add(user);
            db.SaveChanges();
        }
        return View();
    }

}

