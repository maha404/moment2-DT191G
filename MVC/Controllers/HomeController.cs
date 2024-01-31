using Microsoft.AspNetCore.Mvc;

namespace moment2.controller;

public class HomeController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult OnGetPartial() 
    {
        return PartialView("_Footer");
    }

    [Route("/data")]
    public IActionResult Data()
    {
        ViewBag.data = "Lite text skriven med ViewBag";
        ViewData["data"] = "Lite text skriven med ViewData";
        return View();
    }
}