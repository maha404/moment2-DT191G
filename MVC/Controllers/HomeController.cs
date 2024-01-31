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

    [Route("/data")]
    [HttpPost]
    public IActionResult Data(Data input)
    {
        if(ModelState.IsValid) {
            ViewData["answer"] = input.Name + " " + "är en/ett "+ input.Radios + " " + "och gillar att" + " " + input.Dropdown;
            ViewBag.message = input.Message;
        }
        
        return View();
    }
}