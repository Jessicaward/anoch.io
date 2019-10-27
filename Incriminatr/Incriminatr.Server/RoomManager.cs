using System.Collections.Generic;
using Incriminatr.Model;

namespace Incriminatr.Server
{
    public class RoomManager : IRoomManager
    {
        public IEnumerable<ChatRoom> GetAllChatRooms()
        {
            throw new System.NotImplementedException();
        }

        public int GetNumberOfUsersInRoom(string roomId)
        {
            throw new System.NotImplementedException();
        }
    }
}