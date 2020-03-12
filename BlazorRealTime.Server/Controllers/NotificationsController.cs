using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorRealTime.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BlazorRealTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IHubContext<NotificationsHub> _hubContext;

        public NotificationsController(IHubContext<NotificationsHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromQuery] string title)
        {
            await _hubContext.Clients.All.SendAsync("notification", $"{DateTime.UtcNow}: {title}");
            return Ok("notification has been sent successfully!");
        }
    }
}