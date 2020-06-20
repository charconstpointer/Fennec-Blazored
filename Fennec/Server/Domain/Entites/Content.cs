using System;
using Fennec.Server.Domain.Enums;

namespace Fennec.Server.Domain.Entites
{
    public class Content
    {
        public Guid Id { get;  }
        public string Title { get;  }
        public string Description { get;  }
        public Category Category { get;  }
        public ContentType ContentType { get;  }
        public ContentState ContentState { get;  }

        public Content(Guid id, string title, string description, Category category, ContentType contentType)
        {
            Id = id;
            Title = title;
            Description = description;
            Category = category;
            ContentType = contentType;
            ContentState = ContentState.Created;
        }
    }
}