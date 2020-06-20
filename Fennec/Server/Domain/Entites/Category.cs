using System;

namespace Fennec.Server.Domain.Entites
{
    public class Category
    {
        public Guid Guid { get; private set; }
        public string Name { get; set; }
    }
}