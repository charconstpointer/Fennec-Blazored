using System;
using System.Linq;
using System.Threading.Tasks;
using Fennec.Server.Commands;
using Fennec.Server.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fennec.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertisersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdvertisersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{advertiserId:guid}/advertisements")]
        public async Task<IActionResult> GetAdvertisements(Guid advertiserId)
        {
            return Ok(await _mediator.Send(new GetAdvertisements {AdvertiserId = advertiserId}));
        }

        [HttpGet("{advertiserId:guid}/advertisements/{advertisementId:guid}")]
        public async Task<IActionResult> GetAdvertisements(Guid advertiserId, Guid advertisementId)
        {
            var ads = await _mediator.Send(new GetAdvertisements {AdvertiserId = advertiserId});
            return Ok(ads.FirstOrDefault());
        }

        [HttpGet("advertisements")]
        public async Task<IActionResult> GetAdvertisements()
        {
            return Ok(await _mediator.Send(new GetAdvertisements {AdvertiserId = Guid.NewGuid()}));
        }

        [HttpPost("{advertiserId:guid}/advertisements")]
        public async Task<IActionResult> CraeteAdvertisement(CreateAdvertisement createAdvertisement)
        {
            return Created("", await _mediator.Send(createAdvertisement));
        }
    }
}