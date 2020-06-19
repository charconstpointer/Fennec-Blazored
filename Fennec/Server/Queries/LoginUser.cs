using Fennec.Contracts;
using MediatR;

namespace Fennec.Server.Queries
{
    public class LoginUser : IRequest<LoginDto>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}