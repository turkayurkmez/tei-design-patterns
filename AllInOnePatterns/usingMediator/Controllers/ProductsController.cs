using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using usingMediator.Features.Commands;
using usingMediator.Features.Commands.CreateProduct;

namespace usingMediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest request)
        {
            var id = await mediator.Send(request);
            return Ok(id);

        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductPriceCommand command)
        {
             await mediator.Send(command);

            return Ok(new { message ="Veritabanında güncellendi" });
        }
    }
}
