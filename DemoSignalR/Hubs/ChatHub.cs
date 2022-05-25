using DemoSignalR.Domain;
using DemoSignalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace DemoSignalR.Hubs
{
    public class ChatHub : Hub
    {
        private DataContext _dc;
        public ChatHub(DataContext dc)
        {
            _dc = dc;
        }
        public async Task SendMessage(Message message)
        {
            _dc.Messages.Add(message);
            _dc.SaveChanges();
            await Clients.All.SendAsync("messageSending", message);
        }
    }
}
