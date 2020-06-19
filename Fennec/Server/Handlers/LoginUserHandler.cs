using Fennec.Contracts;
using Fennec.Server.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Fennec.Server.Handlers
{
    public class LoginUserHandler : IRequestHandler<LoginUser, LoginDto>
    {
        public Task<LoginDto> Handle(LoginUser request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new LoginDto{Token = "dhjsakdhakjdsa"});
        }
    }
}