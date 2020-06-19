using System.Collections.Generic;
using Fennec.Contracts;

namespace Fennec.Client.Store.GetArticlesUseCase
{
    public class GetArticlesResultAction
    {
        public ICollection<ArticleDto> Articles { get;  }

        public GetArticlesResultAction(ICollection<ArticleDto> articles)
        {
            Articles = articles;
        }
    }
}