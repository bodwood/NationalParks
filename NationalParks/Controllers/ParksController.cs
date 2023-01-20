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

  
}
}