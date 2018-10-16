using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    public class MiscEndpoints
    {
        public MiscEndpoints(NekosClient client)
        {
            Client = client;
        }
        private readonly NekosClient Client;
        private readonly string API = "https://nekos.life/api/v2/img/";

        public async Task<Request> Cat()
        {
            return await Client.SendRequest(API + "meow");
        }

        public async Task<Request> Lizard()
        {
            return await Client.SendRequest(API + "lizard");
        }
    }
}
