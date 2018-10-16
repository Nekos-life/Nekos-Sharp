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
        public MiscEndpoints(NekosClient client)
        {
            Client = client;
        }
        private readonly NekosClient Client;
        private readonly string API = "https://nekos.life/api/v2/img/";

        /// <summary>
        /// Cute cats but very evil
        /// </summary>
        public async Task<Request> Cat()
        {
            return await Client.SendRequest(API + "meow");
        }

        /// <summary>
        /// Lizards can be cute baka
        /// </summary>
        public async Task<Request> Lizard()
        {
            return await Client.SendRequest(API + "lizard");
        }
        
        /// <summary>
        /// Random 8ball response in an image
        /// </summary>
        public async Task<Request> EightBall()
        {
            return await Client.SendRequest(API + "8ball");
        }
    }
}
