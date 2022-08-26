using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace API.Controllers
{
    //TODO
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        private ISender _mediator = null!;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
    }
}
