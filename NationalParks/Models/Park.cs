using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    [StringLength(50)]
    public string ParkName { get; set; }

    [Required]
    [StringLength(30)]
    public string Region { get; set; }

    [Required]
    [StringLength(20)]
    public string StateName { get; set; }

    [Required]
    [Range(0, 200, ErrorMessage = "Rating must be between 0 and 5.")]
    public int Rating { get; set; }
  }
}