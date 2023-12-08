using System.ComponentModel.DataAnnotations;

namespace Clase4.Models;

public class Movie
{
    public string Code { get; set; }
    [Display(Name = "Movie name")]
    [Required]
    public string Name { get; set; }
    [Range(2, 800)]
    public int Minutes { get; set; }
    public string Category { get; set; }
    public string Review { get; set; }
}