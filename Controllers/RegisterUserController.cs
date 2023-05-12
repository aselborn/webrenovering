using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using renovering.Models;
using renovering.Services;

namespace MvcMovie.Controllers;

public class RegisterController : Controller
{
    private readonly IUserService _userService;
    private readonly ILogger _logger;
    public RegisterController(ILogger<RegisterController> logger, IUserService userService)
    {
        _userService = userService;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Register(User theUser)
    {
        var myUser = theUser;
        _userService.Add( theUser);
        return LocalRedirect("home");
        //return View(myUser);
    }
}