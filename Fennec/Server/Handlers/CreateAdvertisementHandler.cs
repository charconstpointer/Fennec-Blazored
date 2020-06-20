using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fennec.Server.Commands;
using Fennec.Server.Domain;
using MediatR;

namespace Fennec.Server.Handlers
{
    public class CreateAdvertisementHandler : IRequestHandler<CreateAdvertisement>
    {
        private readonly ICollection<Advertisement> _advertisements;

        public CreateAdvertisementHandler(ICollection<Advertisement> advertisements)
        {
            _advertisements = advertisements;
        }

        public Task<Unit> Handle(CreateAdvertisement request, CancellationToken cancellationToken)
        {
            var advertisement = Advertisement.Create(Guid.NewGuid(), request.Name, request.PricePerView);
            _advertisements.Add(advertisement);
            return Unit.Task;
        }
    }
}