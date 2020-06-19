using System;

namespace Fennec.Server.Domain
{
    public class Advertisement
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public DateTime DateOfCreation { get; private set; }
        public float PricePerSecond { get; private set; }

        private Advertisement(Guid id, string name, float pricePerSecond)
        {
            Id = id;
            Name = name;
            PricePerSecond = pricePerSecond;
            DateOfCreation = DateTime.UtcNow;
        }

        public static Advertisement Create(Guid id, string name, float pricePerSecond)
        {
            var advertisement = new Advertisement(id, name, pricePerSecond);
            return advertisement;
        }
    }
}