using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Incriminatr.Models;

namespace Incriminatr.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Lobby()
        {
            //todo: remove this test code:
            var model = new LobbyViewModel();
            model.ChatRooms = new List<ChatRoom>
            {
                new ChatRoom(){ExpiryDate = DateTime.Now, Key = Guid.NewGuid().ToString(), Name = "aw yea"},
                new ChatRoom(){ExpiryDate = DateTime.Now, Key = Guid.NewGuid().ToString(), Name = "aw yea 2"}
            };
            
            
            return View();
        }

        public ActionResult Room()
        {
            return View();
        }
    }
}