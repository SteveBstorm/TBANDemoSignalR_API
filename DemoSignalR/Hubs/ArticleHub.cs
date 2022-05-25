using Microsoft.AspNetCore.SignalR;

namespace DemoSignalR.Hubs
{
    public class ArticleHub : Hub
    {
        public async Task NotifierAddAricle()
        {
            await Clients.All.SendAsync("articleListUpdated");
        }
    }
}
