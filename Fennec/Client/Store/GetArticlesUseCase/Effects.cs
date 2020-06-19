using Fennec.Contracts;
using Fluxor;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Fennec.Client.Store.GetArticlesUseCase
{
    public class Effects
    {
        private readonly HttpClient _client;

        public Effects(HttpClient client)
        {
            _client = client;
        }

        [EffectMethod]
        public async Task HandleGetArticlesAction(GetArticlesAction action, IDispatcher dispatcher)
        {
            var articles = await _client.GetFromJsonAsync<ICollection<ArticleDto>>("/articles");
            dispatcher.Dispatch(new GetArticlesResultAction(articles));
        }
    }
}