using System;

namespace Fennec.Contracts
{
    public class AdvertisementDto
    {
        public Guid Id { get; set; }
        public string Name { get;  set; }
        public string Path { get; set; }
        public DateTime DateOfCreation { get;  set; }
        public float PricePerView { get;  set; }
    }
}