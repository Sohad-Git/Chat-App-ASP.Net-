﻿using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNetCore.SignalR;
using Hub = Microsoft.AspNet.SignalR.Hub;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}