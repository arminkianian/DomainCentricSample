﻿using AuctionManagement.Application.Contracts;
using Framework.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Input;

namespace AuctionManagement.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly ICommandBus _bus;

        public AuctionsController(ICommandBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public IActionResult Post(OpenAuctionCommand command)
        {
            _bus.Dispatch(command);
            return Ok();
        }
    }
}
