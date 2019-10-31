using System.Collections.Generic;
using Incriminatr.Web.Model;
using Incriminatr.Web.Implementation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Incriminatr.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRoomManager _roomManager;
        public IEnumerable<ChatRoom> ChatRooms { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IRoomManager roomManager)
        {
            _logger = logger;
            _roomManager = roomManager;
        }

        public void OnGet()
        {
            ChatRooms = _roomManager.GetAllChatRooms();
        }
    }
}