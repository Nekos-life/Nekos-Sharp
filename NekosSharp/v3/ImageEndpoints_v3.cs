using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// All the weeb images you would ever need
    /// </summary>
    public class ImageEndpoints_v3
    {
        public ImageEndpoints_v3(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Get cute neko girls
        /// </summary>
        public async Task<Request> Neko()
        {
            return await Client.SendRequest(true, "sfw/img/neko");
        }

        /// <summary>
        /// Get cute neko girls in gif
        /// </summary>
        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(true, "sfw/gif/neko");
        }

        /// <summary>
        /// Get bushy fox girls
        /// </summary>
        public async Task<Request> Fox()
        {
            return await Client.SendRequest(true, "sfw/img/kitsune");
        }

        /// <summary>
        /// Get a holo image (fox character)
        /// </summary>
        public async Task<Request> Holo()
        {
            return await Client.SendRequest(true, "sfw/img/holo");
        }

        /// <summary>
        /// Get a random weeb avatar
        /// </summary>
        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(true, "sfw/img/no_tag_avatar");
        }

        /// <summary>
        /// Get a random neko avatar
        /// </summary>
        public async Task<Request> NekoAvatar()
        {
            return await Client.SendRequest(true, "sfw/img/neko_avatars_avatar");
        }

        /// <summary>
        /// Get an awesome anime wallpaper
        /// </summary>
        public async Task<Request> Wallpaper()
        {
            return await Client.SendRequest(true, "sfw/img/wallpaper");
        }

        /// <summary>
        /// Get a random waifu to steal
        /// </summary>
        public async Task<Request> Waifu()
        {
            return await Client.SendRequest(true, "sfw/img/waifu");
        }

        /// <summary>
        /// Very smug 
        /// </summary>
        public async Task<Request> SmugGif()
        {
            return await Client.SendRequest(true, "sfw/gif/smug");
        }

        /// <summary>
        /// Baka baka sexy bitch
        /// </summary>
        public async Task<Request> BakaGif()
        {
            return await Client.SendRequest(true, "sfw/gif/baka");
        }
    }
}
