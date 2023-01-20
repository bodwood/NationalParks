using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParks.Models;

namespace NationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly NationalParksContext _db;

    public ParksController(NationalParksContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string region, string stateName, int rating, bool sortRating, bool random)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }
      if (region != null)
      {
        query = query.Where(entry => entry.Region == region);
      }
      if (stateName != null)
      {
        query = query.Where(entry => entry.StateName == stateName);
      }
      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating >= rating);
      }
      if (sortRating == true)
      {
        query = query.OrderByDescending(park => park.Rating);
      }
      if (random == true)
      {
        int count = 0;
        foreach (Park i in _db.Parks)
        {
          count++;
        }
        Random rand = new Random();
        int randId = rand.Next(1, count + 1);
        query = query.Where(entry => entry.ParkId == randId);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      return park;
    }
  }
}