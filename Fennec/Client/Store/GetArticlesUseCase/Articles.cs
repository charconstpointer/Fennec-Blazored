using Fluxor;
using Microsoft.AspNetCore.Components;

namespace Fennec.Client.Store.GetArticlesUseCase
{
    public class Articles
    {
        [Inject] public IState<ArticlesState> ArticlesState { get; set; }
        [Inject] public IDispatcher Dispatcher { get; set; }

        private void FetchArticles()
        {
            var action = new GetArticlesAction();
            Dispatcher.Dispatch(action);
        }
    }
}