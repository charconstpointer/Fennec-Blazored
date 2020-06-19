using System;
using System.Collections.Generic;
using Fennec.Contracts;
using MediatR;

namespace Fennec.Server.Queries
{
    public class GetAdvertisements : IRequest<IEnumerable<AdvertisementDto>>
    {
        public Guid AdvertiserId { get; set; }
    }
}