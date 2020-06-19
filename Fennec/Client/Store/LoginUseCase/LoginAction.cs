using Fennec.Client.Models;

namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginAction
    {
        public LoginRequest LoginRequest { get; set; }

        public LoginAction(LoginRequest loginRequest)
        {
            LoginRequest = loginRequest;
        }
    }
}