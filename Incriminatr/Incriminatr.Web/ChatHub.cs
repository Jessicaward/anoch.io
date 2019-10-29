using Microsoft.AspNetCore.SignalR;
namespace Incriminatr
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}