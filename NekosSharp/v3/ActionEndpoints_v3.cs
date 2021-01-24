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
        public Task<Request> TickleGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/tickle", Count);
        

        /// <summary>
        /// Poke someone for fun
        /// </summary>
        public Task<Request> PokeGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/poke", Count);
        

        /// <summary>
        /// Kiss someone you love
        /// </summary>
        public Task<Request> KissGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/kiss", Count);
        
       
        /// <summary>
        /// Slap a bad user
        /// </summary>
        public Task<Request> SlapGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/slap", Count);
        

        /// <summary>
        /// Cuddle your waifus
        /// </summary>
        public Task<Request> CuddleGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/cuddle", Count);
        

        /// <summary>
        /// Hug someone
        /// </summary>
        public Task<Request> HugGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/hug", Count);
        

        /// <summary>
        /// Pat someone for being cute :3
        /// </summary>
        public Task<Request> PatGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/pat", Count);
        

        /// <summary>
        /// Feed your lover
        /// </summary>
        public Task<Request> FeedGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/feed", Count);
        
    }
}
