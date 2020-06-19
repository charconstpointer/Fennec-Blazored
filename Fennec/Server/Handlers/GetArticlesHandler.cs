using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Fennec.Contracts;
using Fennec.Server.Domain;
using Fennec.Server.Queries;
using MediatR;

namespace Fennec.Server.Handlers
{
    public class GetArticlesHandler : IRequestHandler<GetArticles, IEnumerable<ArticleDto>>
    {
        private readonly ICollection<Article> _articles;

        public GetArticlesHandler(ICollection<Article> articles)
        {
            _articles = articles;
        }

        public async Task<IEnumerable<ArticleDto>> Handle(GetArticles request, CancellationToken cancellationToken)
        {
            return _articles.Select(a => new ArticleDto
            {   
                Title = a.Title, Description = a.Description, Id = a.Id, Tags = a.Tags
            });
        }
    }
}