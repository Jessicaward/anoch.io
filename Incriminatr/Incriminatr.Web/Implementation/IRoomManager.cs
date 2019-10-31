using System.Collections.Generic;
using Incriminatr.Web.Model;
using Incriminatr.Web.Model;

namespace Incriminatr.Web.Implementation
{
    public interface IRoomManager
    {
        IEnumerable<ChatRoom> GetAllChatRooms();
        ChatRoom GetChatRoomById(string id);
        int GetNumberOfUsersInRoom(string roomId);
    }
}