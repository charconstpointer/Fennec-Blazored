using Fennec.Contracts;
using Fennec.Server.Domain;
using Fennec.Server.Queries;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fennec.Server.Handlers
{
    public class GetAdvertisementsHandler : IRequestHandler<GetAdvertisements, IEnumerable<AdvertisementDto>>
    {
        private readonly ICollection<Advertisement> _advertisements;

        public GetAdvertisementsHandler(ICollection<Advertisement> advertisements)
        {
            _advertisements = advertisements;
        }

        public async Task<IEnumerable<AdvertisementDto>> Handle(GetAdvertisements request,
            CancellationToken cancellationToken)
        {
            var ads= _advertisements.Select(x => new AdvertisementDto
            {
                DateOfCreation = x.DateOfCreation,
                Id = x.Id,
                Name = x.Name,
                PricePerView = x.PricePerSecond
            });
            return ads;
        }
    }
}