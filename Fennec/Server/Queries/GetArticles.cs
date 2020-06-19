using System.Collections.Generic;
using Fennec.Contracts;
using MediatR;

namespace Fennec.Server.Queries
{
    public class GetArticles : IRequest<IEnumerable<ArticleDto>>
    {
        
    }
}