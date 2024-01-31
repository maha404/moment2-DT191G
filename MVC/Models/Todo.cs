using System;
using System.ComponentModel.DataAnnotations;
namespace moment2.Model;

public class Todo 
{
    // public int Id { get; set; }
    [Required(ErrorMessage ="Fältet får inte vara tomt!")]
    public string? Task { get; set; }
    // public bool Status { get; set; }

    public Todo() {}
    public Todo(string ts)
    {
        this.Task = ts;
    }
}