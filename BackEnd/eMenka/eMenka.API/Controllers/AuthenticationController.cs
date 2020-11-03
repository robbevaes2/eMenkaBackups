using eMenka.API.AuthenticationModels;
using eMenka.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Stage_API;

namespace eMenka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOptions<TokenSettings> _tokenSettings;


        public AuthenticationController(RoleManager<Role> roleManager, SignInManager<User> signInManager, IOptions<TokenSettings> tokenSettings)
        {
            _userManager = signInManager.UserManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _tokenSettings = tokenSettings;
        }

        #region register

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Login
        [HttpPost("token")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var user = await _userManager.FindByNameAsync(model.Email);

            if (user == null) return StatusCode(403, "Het e-mailadres of wachtwoord is ongeldig!");

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);

            if (!result.Succeeded)
                return StatusCode(403,
                    !result.IsLockedOut
                        ? "Het e-mailadres of wachtwoord is ongeldig!"
                        : "Te veel incorrecte pogingen. Wacht 5 minuten en probeer later opnieuw.");

            var token = await CreateJwtToken(user);
            return Ok(token);
        }

        private async Task<object> CreateJwtToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var allClaims = new[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            }.Union(userClaims).ToList();

            var userRoles = await _userManager.GetRolesAsync(user);
            
            //Adds roles to claims
            allClaims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            var keyBytes = Encoding.UTF8.GetBytes(_tokenSettings.Value.Key);
            var symmetricSecurityKey = new SymmetricSecurityKey(keyBytes);
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _tokenSettings.Value.Issuer,
                audience: _tokenSettings.Value.Audience,
                claims: allClaims,
                expires: DateTime.UtcNow.AddMinutes(_tokenSettings.Value.ExpirationTimeInMinutes),
                signingCredentials: signingCredentials);

            var encryptedToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            return encryptedToken;
        }

        #endregion

    }
}