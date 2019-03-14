using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// All the weeb images you would ever need
    /// </summary>
    public class ImageEndpoints
    {
        public ImageEndpoints(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Get cute neko girls
        /// </summary>
        public async Task<Request> Neko()
        {
            return await Client.SendRequest(false, "img/neko");
        }

        /// <summary>
        /// Get cute neko girls in gif
        /// </summary>
        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(false, "img/ngif");
        }

        /// <summary>
        /// Get bushy fox girls
        /// </summary>
        public async Task<Request> Fox()
        {
            return await Client.SendRequest(false, "img/fox_girl");
        }

        /// <summary>
        /// Very smug 
        /// </summary>
        public async Task<Request> Smug()
        {
            return await Client.SendRequest(false, "img/smug");
        }

        /// <summary>
        /// Get a holo image (fox character)
        /// </summary>
        public async Task<Request> Holo()
        {
            return await Client.SendRequest(false, "img/holo");
        }

        /// <summary>
        /// Get a random weeb avatar
        /// </summary>
        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(false, "img/avatar");
        }

        /// <summary>
        /// Get an awesome anime wallpaper
        /// </summary>
        public async Task<Request> Wallpaper()
        {
            return await Client.SendRequest(false, "img/wallpaper");
        }

        /// <summary>
        /// Baka baka sexy bitch
        /// </summary>
        public async Task<Request> Baka()
        {
            return await Client.SendRequest(false, "img/baka");
        }

        /// <summary>
        /// Get a random waifu to steal
        /// </summary>
        public async Task<Request> Waifu()
        {
            return await Client.SendRequest(false, "img/waifu");
        }
    }
}
