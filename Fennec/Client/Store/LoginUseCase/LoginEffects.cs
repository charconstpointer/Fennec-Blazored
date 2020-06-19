using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Fennec.Client.Models;
using Fennec.Client.Store.GetArticlesUseCase;
using Fennec.Contracts;
using Fluxor;

namespace Fennec.Client.Store.LoginUseCase
{
    public class LoginEffects
    {
        private readonly HttpClient _client;

        public LoginEffects(HttpClient client)
        {
            _client = client;
        }

        [EffectMethod]
        public async Task HandleLoginAction(LoginAction action, IDispatcher dispatcher)
        {
            var response = await _client.PostAsJsonAsync("/users", action.LoginRequest);
            var credentials = await response.Content.ReadFromJsonAsync<LoginDto>();
            dispatcher.Dispatch(new LoginResultAction(credentials.Token));
        }
    }
}