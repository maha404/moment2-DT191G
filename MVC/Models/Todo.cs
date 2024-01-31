using System;
namespace moment2.Model;

public class Todo 
{
    // public int Id { get; set; }
    public string? Task { get; set; }
    // public bool Status { get; set; }

    public Todo() {}
    public Todo(string ts)
    {
        this.Task = ts;
    }
}