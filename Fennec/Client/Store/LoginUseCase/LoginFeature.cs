using Fluxor;

namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginFeature : Feature<LoginState>
    {
        public override string GetName()
        {
            return "Login";
        }

        protected override LoginState GetInitialState()
        {
            return new LoginState("", "", false);
        }
    }
}