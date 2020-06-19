using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fennec.Server.Commands;
using Fennec.Server.Domain;
using MediatR;

namespace Fennec.Server.Handlers
{
    public class CreateArticleHandler : IRequestHandler<CreateArticle>
    {
        private readonly ICollection<Article> _articles;

        public CreateArticleHandler(ICollection<Article> articles)
        {
            _articles = articles;
        }

        public Task<Unit> Handle(CreateArticle request, CancellationToken cancellationToken)
        {
            var article = Article.Create(Guid.NewGuid(), request.Title, request.Description, request.Tags);
            _articles.Add(article);
            return Unit.Task;
        }
    }
}