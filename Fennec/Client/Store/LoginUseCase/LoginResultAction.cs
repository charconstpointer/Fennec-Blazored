namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginResultAction
    {
        public string Token { get;  }

        public LoginResultAction(string token)
        {
            Token = token;
        }
    }
}