using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    public class ActionEndpoints
    {
        public ActionEndpoints(NekosClient client)
        {
            Client = client;
        }
        private readonly NekosClient Client;
        private readonly string API = "https://nekos.life/api/v2/img/";

        public async Task<Request> Poke()
        {
            return await Client.SendRequest(API + "poke");
        }

        public async Task<Request> Tickle()
        {
            return await Client.SendRequest(API + "tickle");
        }

        public async Task<Request> Kiss()
        {
            return await Client.SendRequest(API + "kiss");
        }

        public async Task<Request> Slap()
        {
            return await Client.SendRequest(API + "slap");
        }

        public async Task<Request> Cuddle()
        {
            return await Client.SendRequest(API + "cuddle");
        }

        public async Task<Request> Hug()
        {
            return await Client.SendRequest(API + "hug");
        }

        public async Task<Request> Pat()
        {
            return await Client.SendRequest(API + "pat");
        }

        public async Task<Request> Feed()
        {
            return await Client.SendRequest(API + "feed");
        }
    }
}
