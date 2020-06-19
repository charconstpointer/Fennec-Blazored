﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Fennec.Server.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fennec.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdvertisersController :ControllerBase
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

        [HttpGet]
        public async Task<IActionResult> GetAdvertisementss()
        {
            return Ok(await _mediator.Send(new GetAdvertisements { AdvertiserId = Guid.NewGuid() }));
        }
    }
}