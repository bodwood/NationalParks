using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using NationalParks.Models;

namespace NationalParks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    public static User user = new User();
    // private readonly IConfiguration _configuration;
    // private readonly IUserService _userService;

    //  public AuthController(IConfiguration configuration, IUserService userService)
    // {
    //   _configuration = configuration;
    //   _userService = userService;
    // }

    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(UserDto request)
    {
      CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

      user.Username = request.Username;
      user.PasswordHash = passwordHash;
      user.PasswordSalt = passwordSalt;

      return Ok(user);
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
      using(var hmac = new HMACSHA512())
      {
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
      }
    }
  }
}