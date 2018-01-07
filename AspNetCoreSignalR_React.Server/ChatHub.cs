using Microsoft.AspNetCore.SignalR;

namespace AspNetCoreSignalR_React.Server
{
    public class ChatHub : Hub
    {
        public void SendToAll(string name, string message, string chatRoom)
        {
            Clients.All.InvokeAsync("sendToAll"+chatRoom, name, message, chatRoom);
        }
    }
}