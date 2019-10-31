using Incriminatr.Web.Model;
using Incriminatr.Web.Implementation;

namespace Incriminatr.Web.Implementation
{
    public class ClientManager : IClientManager 
    {
        public Client RequestNewClient()
        {
            //todo: Create new client in database, return client object.
            throw new System.NotImplementedException();
        }

        public Client GetExistingClientInfo(string identifier)
        {
            //todo: go to database and query based on identifier
            throw new System.NotImplementedException();
        }

        public Client GetExistingClientInfoFromGuid(string guid)
        {
            //todo: go to database and query based on guid
            throw new System.NotImplementedException();
        }
    }
}