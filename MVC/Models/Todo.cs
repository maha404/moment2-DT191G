using System;
using System.ComponentModel.DataAnnotations;
namespace moment2.Model;

public class Todo 
{
    // Data annotation + errormeddelande
    [Required(ErrorMessage ="Fältet får inte vara tomt!")]
    public string? Task { get; set; }

    // Konstruktor
    public Todo() {}

    // Konstruktor med parametrar
    public Todo(string ts)
    {
        this.Task = ts;
    }
}