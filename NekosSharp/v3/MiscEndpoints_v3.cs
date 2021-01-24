using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Misc images for non-weeb stuff
    /// </summary>
    public class MiscEndpoints_v3
    {
        public MiscEndpoints_v3(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Cute cats but very evil
        /// </summary>
        public Task<Request> Cat(int Count = 1)
            => Client.SendRequest(true, "sfw/img/cat", Count);
        

        /// <summary>
        /// Lizards can be cute baka
        /// </summary>
        public Task<Request> Lizard(int Count = 1)
            => Client.SendRequest(true, "sfw/img/lizard", Count);
        

        /// <summary>
        /// Random 8ball response in an image
        /// </summary>
        public Task<Request> EightBall(int Count = 1)
            => Client.SendRequest(true, "sfw/img/8ball", Count);
        
    }
}
