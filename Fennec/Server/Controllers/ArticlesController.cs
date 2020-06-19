using System;
using System.Threading.Tasks;
using Fennec.Server.Commands;
using Fennec.Server.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Fennec.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticlesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticle createArticle)
        {
            return Created("", await _mediator.Send(createArticle));
        }

        [HttpGet]
        public async Task<IActionResult> GetArticles()
        {
            return Ok(await _mediator.Send(new GetArticles()));
        }

        [HttpGet("articleId:guid")]
        public async Task<IActionResult> GetArticle(Guid articleId)
        {
            return Ok(await _mediator.Send(new GetArticleById{ ArticleId = articleId }));
        }
    }
}