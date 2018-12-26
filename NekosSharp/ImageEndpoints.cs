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
        private readonly string API = "https://nekos.life/api/v2/img/";

        /// <summary>
        /// Get cute neko girls
        /// </summary>
        public async Task<Request> Neko()
        {
            return await Client.SendRequest(API + "neko");
        }

        /// <summary>
        /// Get cute neko girls in gif
        /// </summary>
        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(API + "ngif");
        }

        /// <summary>
        /// Get bushy fox girls
        /// </summary>
        public async Task<Request> Fox()
        {
            return await Client.SendRequest(API + "fox_girl");
        }

        /// <summary>
        /// Very smug 
        /// </summary>
        public async Task<Request> Smug()
        {
            return await Client.SendRequest(API + "smug");
        }

        /// <summary>
        /// Get a holo image (fox character)
        /// </summary>
        public async Task<Request> Holo()
        {
            return await Client.SendRequest(API + "holo");
        }

        /// <summary>
        /// Get a random weeb avatar
        /// </summary>
        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(API + "avatar");
        }

        /// <summary>
        /// Get an awesome anime wallpaper
        /// </summary>
        public async Task<Request> Wallpaper()
        {
            return await Client.SendRequest(API + "wallpaper");
        }

        /// <summary>
        /// Baka baka sexy bitch
        /// </summary>
        public async Task<Request> Baka()
        {
            return await Client.SendRequest(API + "baka");
        }

        /// <summary>
        /// Get a random waifu to steal
        /// </summary>
        public async Task<Request> Waifu()
        {
            return await Client.SendRequest(API + "waifu");
        }
    }
}
