using System.ComponentModel.DataAnnotations;

namespace NationalParks.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string ParkName { get; set; }
    public string Region { get; set; }
    public string StateName { get; set; }
    public int Rating { get; set; }
  }
}