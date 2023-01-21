using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class UserDto
  {
    [Required]
    [StringLength(20)]
    public string Username { get; set; }
    [Required]
    [StringLength(20)]
    public string Password { get; set; }
  }
}