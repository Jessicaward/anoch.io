namespace Incriminatr.Model
{
    public class Client
    {
        //Ok so basically a "client" is a browser window with the chat on.
        
        /// <summary>
        /// Identifier is probably an IP Address.
        /// Or maybe it should be some sort of "session ID"
        /// </summary>
        public string Identifier { get; set; }
        
        //This is what will be given to each client, to use as a username.
        public string CurrentGuid { get; set; }
    }
}