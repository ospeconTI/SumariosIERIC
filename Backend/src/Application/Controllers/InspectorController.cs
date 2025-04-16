using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OSPeConTI.SumariosIERIC.Application.Commands;
using OSPeConTI.SumariosIERIC.Application.Queries;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace OSPeConTI.SumariosIERIC.Application
{
    [Route("v1/[controller]")]
    [ApiController]

    public class InspectorController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<InspectorController> _logger;

        public InspectorController(
            IMediator mediator,
            ILogger<InspectorController> logger

       )
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> AddInspectorAsync([FromBody] AddInspectorCommand command)
        {
            Guid id = await _mediator.Send(command);
            return Ok(id);
        }

    }
}