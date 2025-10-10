using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace ApiEPharmacy.Services
{
    public static class TokenService
    {
        public static string GerarToken(string login, string nome)
        {
            var key = Encoding.ASCII.GetBytes("*-++-**-++-**-++++++++++++~My+EPharmacy+App~++++++++++++-**-++-**-++-*"); // 🔒 depois colocamos no appsettings.json

            var tokenConfig = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, nome),
                    new Claim("login", login)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenConfig);
            return tokenHandler.WriteToken(token);
        }
    }
}
