using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Perform action images on another user
    /// </summary>
    public class ActionEndpoints
    {
        public ActionEndpoints(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Poke someone for fun
        /// </summary>
        public async Task<Request> Poke()
        {
            return await Client.SendRequest(false, "img/poke");
        }

        /// <summary>
        /// Tickle those funny bones
        /// </summary>
        public async Task<Request> Tickle()
        {
            return await Client.SendRequest(false, "img/tickle");
        }

        /// <summary>
        /// Kiss someone you love
        /// </summary>
        public async Task<Request> Kiss()
        {
            return await Client.SendRequest(false, "img/kiss");
        }
        
        /// <summary>
        /// Slap a bad user
        /// </summary>
        public async Task<Request> Slap()
        {
            return await Client.SendRequest(false, "img/slap");
        }

        /// <summary>
        /// Cuddle your waifus
        /// </summary>
        public async Task<Request> Cuddle()
        {
            return await Client.SendRequest(false, "img/cuddle");
        }

        /// <summary>
        /// Hug someone
        /// </summary>
        public async Task<Request> Hug()
        {
            return await Client.SendRequest(false, "img/hug");
        }

        /// <summary>
        /// Pat someone for being cute :3
        /// </summary>
        public async Task<Request> Pat()
        {
            return await Client.SendRequest(false, "img/pat");
        }

        /// <summary>
        /// Feed your lover
        /// </summary>
        public async Task<Request> Feed()
        {
            return await Client.SendRequest(false, "img/feed");
        }
    }
}
