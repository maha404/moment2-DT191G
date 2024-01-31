using System;
using System.ComponentModel.DataAnnotations;
namespace moment2.Model;

public class Data
{
    [Required(ErrorMessage = "Namn är obligatoriskt!")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Ras är obligatorisk!")]
    public string? Radios { get; set; }

    [Required(ErrorMessage = "Aktivitet är obligatorisk!")]
    public string? Dropdown { get; set; } 

    [Required(ErrorMessage = "Meddelande är obligatorisk!")]
    public string? Message { get; set; }

    public Data() {}

    public Data(string name, string radios, string dropdown, string message)
    {
        this.Name = name;
        this.Radios = radios;
        this.Dropdown = dropdown;
        this.Message = message;
    }
}