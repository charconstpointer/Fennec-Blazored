using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Fennec.Contracts;
using Fennec.Server.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Fennec.Server.Handlers
{
    public class LoginUserHandler : IRequestHandler<LoginUser, LoginDto>
    {
        private readonly string _key;

        public LoginUserHandler(IConfiguration configuration)
        {
            _key = configuration["Key"];
        }

        public Task<LoginDto> Handle(LoginUser request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new LoginDto{Token = CreateToken(request.Username, _key), Username = request.Username});
        }

        private string CreateToken(string username, string key)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "apbd",
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(100),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_key)),
                        SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var wt = tokenHandler.WriteToken(token);
            return wt;
        }
    }
}