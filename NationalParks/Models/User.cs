using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class User
  {
    [Required]
    [StringLength(20)]
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
  }
}