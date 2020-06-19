using System;
using Fennec.Contracts;
using MediatR;

namespace Fennec.Server.Queries
{
    public class GetArticleById : IRequest<ArticleDto>
    {
        public Guid ArticleId { get; set; }
    }
}