using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace yapf1.Models.ChatModels
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string imageFile, string userName)
        {
            await Clients.All.SendAsync("Send", message, imageFile, Context.User.FindFirst("Name").Value, Context.ConnectionId);
        }
         
         public override async Task OnConnectedAsync()
        {
           await Clients.All.SendAsync("Notify", $"{Context.User.FindFirst("Name").Value} вошел в чат");
             
           var context = this.Context.GetHttpContext();
            // получаем кук name
            if (context.Request.Cookies.ContainsKey("Name"))
            {
                string userName;
                if(context.Request.Cookies.TryGetValue("name", out userName))
                {
                    Debug.WriteLine($"name = {userName}");
                }
            }
            // получаем юзер-агент
            Debug.WriteLine($"UserAgent = {context.Request.Headers["User-Agent"]}");
            // получаем ip
            Debug.WriteLine($"RemoteIpAddress = {context.Connection.RemoteIpAddress.ToString()}");
 
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("Notify", $"{Context.User.FindFirst("Name").Value} покинул чат");
            await base.OnDisconnectedAsync(exception);
        }



        
    }
    
}