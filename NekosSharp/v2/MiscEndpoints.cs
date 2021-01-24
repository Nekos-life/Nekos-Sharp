using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Misc images for non-weeb stuff
    /// </summary>
    public class MiscEndpoints
    {
        public MiscEndpoints(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Cute cats but very evil
        /// </summary>
        public Task<Request> Cat()
            => Client.SendRequest(false, "img/meow");
        

        /// <summary>
        /// Dogs are very cute
        /// </summary>
        public Task<Request> Dog()
            => Client.SendRequest(false, "img/woof");
        

        /// <summary>
        /// Lizards can be cute baka
        /// </summary>
        public Task<Request> Lizard()
            => Client.SendRequest(false, "img/lizard");
        

        /// <summary>
        /// QUACK!
        /// </summary>
        public Task<Request> Goose()
            => Client.SendRequest(false, "img/goose");
        

        /// <summary>
        /// Random 8ball response in an image
        /// </summary>
        public Task<Request> EightBall()
            => Client.SendRequest(false, "img/8ball");
        
    }
}
