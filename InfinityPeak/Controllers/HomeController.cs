using Microsoft.AspNetCore.Mvc;
using InfinityPeak.Models;

namespace InfinityPeak.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new HomeModel());
    }
    
    public class ErrorViewModel
    {
        public string ErrorMessage { get; set; }
    }
}