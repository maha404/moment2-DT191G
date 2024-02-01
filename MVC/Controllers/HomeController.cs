using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using moment2.Model;

namespace moment2.controller;

public class HomeController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }

    // Hämtar in partial
    public IActionResult OnGetPartial() 
    {
        return PartialView("_Footer");
    }

    [Route("/data")] // Ändring av grundroutingen
    public IActionResult Data()
    {
        return View();
    }

    [Route("/data")] // Ändring av grundroutingen
    [HttpPost] // Post metod för att hämta in data
    public IActionResult Data(Data input)
    {
        if(ModelState.IsValid) {
            ViewData["answer"] = input.Name + " " + "är en/ett "+ input.Radios + " " + "och gillar att" + " " + input.Dropdown;
            ViewBag.message = input.Message;
        }
        
        return View();
    }
}