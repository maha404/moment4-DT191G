using playlist.Models;
using System.ComponentModel.DataAnnotations;

namespace playlist.Models;

public class Song 
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Vänligen skriv in en artist!")]
    public string? Artist { get; set; }
    [Required(ErrorMessage = "Vänligen skriv in en låt-titel!")]
    public string? SongTitle { get; set; }
    [Required(ErrorMessage = "Vänligen skriv en längd på låten!")]
    public int Lenght { get; set; }

    public int CategoryId { get; set; }
}