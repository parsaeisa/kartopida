using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using kartopida_Shared ;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

// namespace kartopida_Server.Controllers
// {    
[ApiController]
    [Route("api/[controller]")]
    public class ClerkIdentityController : ControllerBase
    {
        private static Clerk LoggedOutUser = new Clerk { IsAuthenticated = false };

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;

        public ClerkIdentityController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<UserToken>> CreateUser([FromBody] ClerkLoginModel model)
        {
            var user = new IdentityUser { UserName = model.email, Email = model.email };
            var result = await _userManager.CreateAsync(user, model.password);
            if (result.Succeeded)
            {
                return BuildToken(model);
            }
            else
            {
                return BadRequest("Username or password invalid");
            }

        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] ClerkLoginModel userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.email, 
                userInfo.password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return BuildToken(userInfo);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return BadRequest(ModelState);
            }
        }

        private UserToken BuildToken(ClerkLoginModel loginModel)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, loginModel.email),
                new Claim(ClaimTypes.Name, loginModel.email),
                new Claim("myValue", "whatever I want"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Expiration time
            var expiration = DateTime.UtcNow.AddYears(1);

            JwtSecurityToken token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }

    }
// }