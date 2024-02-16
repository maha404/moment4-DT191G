using System.ComponentModel.DataAnnotations;
using playlist.Models;

namespace playlist.Models;

public class Category 
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Vänligen skriv en genre!")]
    public string? CategoryName { get; set; }

    public List<Song>? Songs { get; set; }
}