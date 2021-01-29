using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace openwheels.Models.ChatModels
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string imageFile)
        {
            await Clients.All.SendAsync("Send", message, imageFile, Context.User.FindFirst("Name").Value, Context.ConnectionId).ConfigureAwait(false);
        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Notify", $"{Context.User.FindFirst("Name").Value} вошел в чат").ConfigureAwait(false);
            var context = this.Context.GetHttpContext();
            // получаем кук name
            if (context.Request.Cookies.ContainsKey("Name"))
            {
                if (context.Request.Cookies.TryGetValue("name", out string userName))
                {
                    Debug.WriteLine($"name = {userName}");
                }
            }
            // получаем юзер-агент
            Debug.WriteLine($"UserAgent = {context.Request.Headers["User-Agent"]}");
            // получаем ip
            Debug.WriteLine($"RemoteIpAddress = {context.Connection.RemoteIpAddress}");
            await base.OnConnectedAsync().ConfigureAwait(false);
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("Notify", $"{Context.User.FindFirst("Name").Value} покинул чат").ConfigureAwait(false);
            await base.OnDisconnectedAsync(exception).ConfigureAwait(false);
        }
    }
}