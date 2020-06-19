using Fluxor;

namespace Fennec.Client.Store.GetArticlesUseCase.Reducers
{
    public static class Reducers
    {
        [ReducerMethod]
        public static ArticlesState ReduceGetArticlesResultAction(ArticlesState state, GetArticlesResultAction action)
            => new ArticlesState(action.Articles);
    }
}