using System;
using System.Collections.Generic;

namespace Fennec.Contracts
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}