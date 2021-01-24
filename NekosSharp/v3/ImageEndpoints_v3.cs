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
        public Task<Request> Neko(int Count = 1)
            => Client.SendRequest(true, "sfw/img/neko", Count);
        

        /// <summary>
        /// Get cute neko girls in gif
        /// </summary>
        public Task<Request> NekoGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/neko", Count);
        

        /// <summary>
        /// Get bushy fox girls
        /// </summary>
        public Task<Request> Fox(int Count = 1)
            => Client.SendRequest(true, "sfw/img/kitsune", Count);
        

        /// <summary>
        /// Get a holo image (fox character)
        /// </summary>
        public Task<Request> Holo(int Count = 1)
            => Client.SendRequest(true, "sfw/img/holo", Count);
        

        /// <summary>
        /// Get a random weeb avatar
        /// </summary>
        public Task<Request> Avatar(int Count = 1)
            => Client.SendRequest(true, "sfw/img/no_tag_avatar", Count);
        

        /// <summary>
        /// Get a random neko avatar
        /// </summary>
        public Task<Request> NekoAvatar(int Count = 1)
            => Client.SendRequest(true, "sfw/img/neko_avatars_avatar", Count);
        

        /// <summary>
        /// Get an awesome anime wallpaper
        /// </summary>
        public Task<Request> Wallpaper(int Count = 1)
            => Client.SendRequest(true, "sfw/img/wallpaper", Count);
        

        /// <summary>
        /// Get a random waifu to steal
        /// </summary>
        public Task<Request> Waifu(int Count = 1)
            => Client.SendRequest(true, "sfw/img/waifu", Count);
        

        /// <summary>
        /// Very smug 
        /// </summary>
        public Task<Request> SmugGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/smug", Count);
        

        /// <summary>
        /// Baka baka sexy bitch
        /// </summary>
        public Task<Request> BakaGif(int Count = 1)
            => Client.SendRequest(true, "sfw/gif/baka", Count);
        
    }
}
