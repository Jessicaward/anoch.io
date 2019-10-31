using Incriminatr.Web.Model;
using Incriminatr.Web.Model;

namespace Incriminatr.Web.Implementation
{
    public interface IClientManager
    {
        /// <summary>
        /// This will request a new client "identity"
        /// </summary>
        /// <returns>Client object</returns>
        Client RequestNewClient();

        /// <summary>
        /// This will return info on an existing client.
        /// </summary>
        /// <param name="identifier">Client Identifier</param>
        /// <returns>Client object</returns>
        Client GetExistingClientInfo(string identifier);

        /// <summary>
        /// This will return info on an existing client.
        /// </summary>
        /// <param name="guid">Client Guid</param>
        /// <returns>Client object</returns>
        Client GetExistingClientInfoFromGuid(string guid);
    }
}