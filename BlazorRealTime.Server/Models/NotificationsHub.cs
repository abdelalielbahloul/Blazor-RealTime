﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRealTime.Server.Models
{
    public class NotificationsHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync(); 
        }
    }
}
