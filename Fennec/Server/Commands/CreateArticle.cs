using System.Collections.Generic;
using MediatR;

namespace Fennec.Server.Commands
{
    public class CreateArticle : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}