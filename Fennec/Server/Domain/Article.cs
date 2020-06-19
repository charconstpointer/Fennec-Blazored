using System;
using System.Collections.Generic;

namespace Fennec.Server.Domain
{
    public class Article
    {
        public Guid Id { get; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Body { get; private set; }
        public IEnumerable<string> Tags { get; private set; }

        private Article(Guid id, string title, string description, string body, IEnumerable<string> tags)
        {
            Id = id;
            Title = title;
            Description = description;
            Tags = tags;
            Body = body;
        }

        public static Article Create(Guid id, string title, string description, string body,
            IEnumerable<string> tags = null)
        {
            return new Article(id, title, description, body, tags);
        }
    }
}