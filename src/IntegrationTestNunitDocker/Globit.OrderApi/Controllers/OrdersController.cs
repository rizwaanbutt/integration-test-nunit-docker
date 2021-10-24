namespace Globit.OrderApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Globit.OrderApi.Application.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public OrdersController(
            IMediator mediator,
            IOrderQueries orderQueries,
            ILogger<OrdersController> logger)
        {
        }
    }
}
