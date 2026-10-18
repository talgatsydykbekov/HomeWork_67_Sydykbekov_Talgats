using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using les70.Models;
using WebApplication3.Models;

namespace les70.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        
        return View("Main");
    }

    public IActionResult Privacy()
    {
        return View("Policy");
    }

    public IActionResult TestPage(int page)
    {
        ViewBag.PageIncrement = ++page;
        return View(new TestPageViewModel{Page = page});
    }
}