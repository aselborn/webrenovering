using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using renovering.Models;
using renovering.Services;
namespace renovering.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserService _userService ;

    public HomeController(ILogger<HomeController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;

    }

    public IActionResult Index()
    {
        var users = _userService.Get();
        return View();
    }

    public IActionResult AddUser()
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
}
