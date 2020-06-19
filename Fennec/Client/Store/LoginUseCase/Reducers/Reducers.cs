using Fluxor;

namespace Fennec.Client.Store.LoginUseCase.Reducers
{
    public static class Reducers
    {
        [ReducerMethod]
        public static LoginState ReduceGetArticlesResultAction(LoginState state, LoginResultAction action)
            => new LoginState("", action.Token, true);
    }
}