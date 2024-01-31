using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using moment2.Model;

namespace moment2.controller;

[Route("/todo")] // Ändring av grundrouting. 
public class TodoController : Controller
{
    [HttpGet]
    public IActionResult Todo()
    {
        var jsonString = System.IO.File.ReadAllText("todos.json");
        var jsonObj = JsonConvert.DeserializeObject<IEnumerable<Todo>>(jsonString);
        return View(jsonObj); // Parameterpassning
    }

    [HttpPost]
    public IActionResult Todo(Todo ts)
    {
        string path = "todos.json";
        // Läs befintig JSON-fil
        var existingJsonString = System.IO.File.ReadAllText(path);
        var newTodo = JsonConvert.DeserializeObject<List<Todo>>(existingJsonString);

        // Lägg till det nya Todo-objektet
        newTodo.Add(ts);

        // Konvertera till JSON och skriv tillbaka till filen
        var updatedJsonString = JsonConvert.SerializeObject(newTodo, Formatting.Indented);
        System.IO.File.WriteAllText(path, updatedJsonString);

        Todo(); // Uppdaterar listan
        return View();
    }

    public IActionResult OnGetPartial() 
    {
        return PartialView("_Footer");
    }
}