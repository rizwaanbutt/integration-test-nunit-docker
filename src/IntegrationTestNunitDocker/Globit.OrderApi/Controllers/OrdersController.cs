namespace Globit.OrderApi.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController(
            IMediator mediator,
            IOrderQueries orderQueries,
            IIdentityService identityService,
            ILogger<OrdersController> logger)
        {
        }
    }
}
