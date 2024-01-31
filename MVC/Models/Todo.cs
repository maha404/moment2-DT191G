using System;
using System.ComponentModel.DataAnnotations;
namespace moment2.Model;

public class Todo 
{
    [Required(ErrorMessage ="Fältet får inte vara tomt!")]
    public string? Task { get; set; }

    public Todo() {}
    public Todo(string ts)
    {
        this.Task = ts;
    }
}