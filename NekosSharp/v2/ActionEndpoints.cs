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
        public Task<Request> Poke()
            =>  Client.SendRequest(false, "img/poke");
        

        /// <summary>
        /// Tickle those funny bones
        /// </summary>
        public Task<Request> Tickle()
            => Client.SendRequest(false, "img/tickle");
        

        /// <summary>
        /// Kiss someone you love
        /// </summary>
        public Task<Request> Kiss()
            => Client.SendRequest(false, "img/kiss");
        
       
        /// <summary>
        /// Slap a bad user
        /// </summary>
        public Task<Request> Slap()
            => Client.SendRequest(false, "img/slap");
        

        /// <summary>
        /// Cuddle your waifus
        /// </summary>
        public Task<Request> Cuddle()
            => Client.SendRequest(false, "img/cuddle");
        

        /// <summary>
        /// Hug someone
        /// </summary>
        public Task<Request> Hug()
            => Client.SendRequest(false, "img/hug");
        

        /// <summary>
        /// Pat someone for being cute :3
        /// </summary>
        public Task<Request> Pat()
            => Client.SendRequest(false, "img/pat");
        

        /// <summary>
        /// Feed your lover
        /// </summary>
        public Task<Request> Feed()
            => Client.SendRequest(false, "img/feed");
        
    }
}
