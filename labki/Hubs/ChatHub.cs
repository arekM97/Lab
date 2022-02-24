using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Entities;
using labki.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace labki.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private IChatMessagesRepository _repository;
        public ChatHub(IChatMessagesRepository repository)
        {
            _repository = repository;
        }


        public override async Task OnConnectedAsync()
        {
            var currentUser = Context.User.Identity.Name;
            await Clients.Caller.SendAsync("OnMessageSent", "ADMIN", $"Welcome to the chat, {currentUser}");
        }


        public async Task SendMessage(string message)
        {
            var currentUser = Context.User.Identity.Name;
            await Clients.All.SendAsync("OnMessageSent", currentUser, message);

            var messageEntity = new ChatMessageEntity
            {
                Username = currentUser,
                Content = message,
            };
            _repository.AddMessage(messageEntity);

        }

    }
}
