using System.Collections.Generic;
using Fennec.Contracts;
using Fluxor;

namespace Fennec.Client.Store.GetArticlesUseCase
{
    public class ArticlesFeature : Feature<ArticlesState>
    {
        public override string GetName()
        {
            return "Articles";
        }

        protected override ArticlesState GetInitialState()
        {
            return new ArticlesState(new List<ArticleDto>());
        }
    }
}