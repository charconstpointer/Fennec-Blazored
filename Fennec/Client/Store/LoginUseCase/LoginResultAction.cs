namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginResultAction
    {
        public string Token { get;  }
        public string Username { get; }

        public LoginResultAction(string token, string username)
        {
            Token = token;
            Username = username;
        }
    }
}