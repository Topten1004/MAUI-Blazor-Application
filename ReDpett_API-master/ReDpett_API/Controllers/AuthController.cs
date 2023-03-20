using Azure;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using ReDpett_API.Modal;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ReDpett_API.Service;

namespace ReDpett_API.Controllers
{
    public class AuthController : Controller
    {
        private readonly IConfiguration _configuration;
        private IDBService dB;

        public AuthController(IConfiguration configuration, IDBService dBService)
        {
            _configuration = configuration;
            dB = dBService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            var claims = new List<Claim>();

            if (dB.ValidateCredentials(model) ) //&& dB.Role.Equals("A")
            {
                claims.Add(new Claim("email", model.Email));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, model.Email));
                //claims.Add(new Claim(ClaimTypes.Role, dB.Role));
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: claims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            else if (dB.ValidateCredentials(model))//&& dB.Role.Equals("D")
            {
                claims.Add(new Claim("email", model.Email));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, model.Email));
                //claims.Add(new Claim(ClaimTypes.Role, dB.Role));
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: claims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            else
            {
                return Unauthorized("Invalid Credentials.. Please try with correct credentials.");
            }

           
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {
            //var userExists = await userManager.FindByNameAsync(model.Username);
            //if (userExists != null)
            //    return StatusCode(StatusCodes.Status500InternalServerError, "User already exists!");
            //var claims = new List<Claim>();

            if (dB.CreateUser(model))
            {
                //claims.Add(new Claim("email", model.Email));
                //claims.Add(new Claim(ClaimTypes.NameIdentifier, model.Email));
                //claims.Add(new Claim(ClaimTypes.Role, "D"));
                //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                
                return Ok("User created successfully!");
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "User creation failed! Please check user details and try again.");
            }
            

            
        }
    }
}
