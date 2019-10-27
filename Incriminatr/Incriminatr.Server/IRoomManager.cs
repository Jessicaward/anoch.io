using System.Collections.Generic;
using Incriminatr.Model;

namespace Incriminatr.Server
{
    public interface IRoomManager
    {
        IEnumerable<ChatRoom> GetAllChatRooms();
        ChatRoom GetChatRoomById(string id);
        int GetNumberOfUsersInRoom(string roomId);
    }
}