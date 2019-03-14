using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Perform action images on another user
    /// </summary>
    public class ActionEndpoints_v3
    {
        public ActionEndpoints_v3(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Tickle those funny bones
        /// </summary>
        public async Task<Request> TickleGif()
        {
            return await Client.SendRequest(true, "sfw/gif/tickle");
        }

        /// <summary>
        /// Poke someone for fun
        /// </summary>
        public async Task<Request> PokeGif()
        {
            return await Client.SendRequest(true, "sfw/gif/poke");
        }

        /// <summary>
        /// Kiss someone you love
        /// </summary>
        public async Task<Request> KissGif()
        {
            return await Client.SendRequest(true, "sfw/gif/kiss");
        }
        
        /// <summary>
        /// Slap a bad user
        /// </summary>
        public async Task<Request> SlapGif()
        {
            return await Client.SendRequest(true, "sfw/gif/slap");
        }

        /// <summary>
        /// Cuddle your waifus
        /// </summary>
        public async Task<Request> CuddleGif()
        {
            return await Client.SendRequest(true, "sfw/gif/cuddle");
        }

        /// <summary>
        /// Hug someone
        /// </summary>
        public async Task<Request> HugGif()
        {
            return await Client.SendRequest(true, "sfw/gif/hug");
        }

        /// <summary>
        /// Pat someone for being cute :3
        /// </summary>
        public async Task<Request> PatGif()
        {
            return await Client.SendRequest(true, "sfw/gif/pat");
        }

        /// <summary>
        /// Feed your lover
        /// </summary>
        public async Task<Request> FeedGif()
        {
            return await Client.SendRequest(true, "sfw/gif/feed");
        }
    }
}
