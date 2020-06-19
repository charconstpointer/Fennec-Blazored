using MediatR;

namespace Fennec.Server.Commands
{
    public class CreateAdvertisement : IRequest
    {
        public string Name { get; set; }
        public float PricePerView { get; set; }
        public string Path { get; set; }
    }
}