namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginState
    {
        public string Username { get; }
        public string Token { get; }
        public bool Logged { get; }
        public LoginState(string username, string token, bool logged)
        {
            Username = username;
            Token = token;
            Logged = logged;
        }
    }
}