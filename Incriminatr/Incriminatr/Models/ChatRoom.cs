using System;

namespace Incriminatr.Models
{
    public class ChatRoom
    {
        public string Name { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Key { get; set; }
    }
}