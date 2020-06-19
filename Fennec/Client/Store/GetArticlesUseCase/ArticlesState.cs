using System.Collections.Generic;
using Fennec.Contracts;

namespace Fennec.Client.Store.GetArticlesUseCase
{
    public class ArticlesState
    {
        public ICollection<ArticleDto> Articles { get;}

        public ArticlesState(ICollection<ArticleDto> articles)
        {
            Articles = articles;
        }
    }
}