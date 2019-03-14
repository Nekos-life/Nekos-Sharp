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
        public async Task<Request> Cat()
        {
            return await Client.SendRequest(true, "sfw/img/cat");
        }

        /// <summary>
        /// Lizards can be cute baka
        /// </summary>
        public async Task<Request> Lizard()
        {
            return await Client.SendRequest(true, "sfw/img/lizard");
        }

        /// <summary>
        /// Random 8ball response in an image
        /// </summary>
        public async Task<Request> EightBall()
        {
            return await Client.SendRequest(true, "sfw/img/8ball");
        }
    }
}
