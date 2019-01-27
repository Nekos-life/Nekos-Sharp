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
        public async Task<Request> Cat()
        {
            return await Client.SendRequest("img/meow");
        }

        /// <summary>
        /// Dogs are very cute
        /// </summary>
        public async Task<Request> Dog()
        {
            return await Client.SendRequest("img/woof");
        }

        /// <summary>
        /// Lizards can be cute baka
        /// </summary>
        public async Task<Request> Lizard()
        {
            return await Client.SendRequest("img/lizard");
        }
        
        /// <summary>
        /// Random 8ball response in an image
        /// </summary>
        public async Task<Request> EightBall()
        {
            return await Client.SendRequest("img/8ball");
        }
    }
}
