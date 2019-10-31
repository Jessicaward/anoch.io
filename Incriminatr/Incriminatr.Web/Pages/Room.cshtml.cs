using Incriminatr.Web.Model;
using Incriminatr.Web.Implementation;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Incriminatr.Pages
{
    public class Room : PageModel
    {
        private readonly IRoomManager _roomManager;
        public ChatRoom CurrentRoom { get; set; }

        public Room(IRoomManager roomManager)
        {
            _roomManager = roomManager;
        }
        
        public void OnGet(string id)
        {
            var room = _roomManager.GetChatRoomById(id);
            CurrentRoom = room;
        }
    }
}