using System;
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
    public class GetArticleByIdHandler : IRequestHandler<GetArticleById, ArticleDto>
    {
        private readonly ICollection<Article> _articles;

        public GetArticleByIdHandler(ICollection<Article> articles)
        {
            _articles = articles;
        }

        public Task<ArticleDto> Handle(GetArticleById request, CancellationToken cancellationToken)
        {
            var article = _articles.FirstOrDefault(a => a.Id == request.ArticleId);
            if (article is null)
            {
                throw new ApplicationException("Article with provided id does not exist");
            }

            return Task.FromResult(new ArticleDto
            {
                Title = article.Title,
                Description = article.Description,
                Id = article.Id,
                Tags = article.Tags
            });
        }
    }
}