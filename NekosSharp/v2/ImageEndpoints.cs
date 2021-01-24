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
        public Task<Request> Neko()
            => Client.SendRequest(false, "img/neko");
        

        /// <summary>
        /// Get cute neko girls in gif
        /// </summary>
        public Task<Request> NekoGif()
            => Client.SendRequest(false, "img/ngif");
        

        /// <summary>
        /// Get bushy fox girls
        /// </summary>
        public Task<Request> Fox()
            => Client.SendRequest(false, "img/fox_girl");
        

        /// <summary>
        /// Very smug 
        /// </summary>
        public Task<Request> Smug()
            => Client.SendRequest(false, "img/smug");
        

        /// <summary>
        /// Get a holo image (fox character)
        /// </summary>
        public Task<Request> Holo()
            => Client.SendRequest(false, "img/holo");
        

        /// <summary>
        /// Get a random weeb avatar
        /// </summary>
        public Task<Request> Avatar()
            => Client.SendRequest(false, "img/avatar");
        

        /// <summary>
        /// Get an awesome anime wallpaper
        /// </summary>
        public Task<Request> Wallpaper()
            => Client.SendRequest(false, "img/wallpaper");
        

        /// <summary>
        /// Baka baka sexy bitch
        /// </summary>
        public Task<Request> Baka()
            => Client.SendRequest(false, "img/baka");
        
        /// <summary>
        /// Get a random waifu to steal
        /// </summary>
        public Task<Request> Waifu()
            => Client.SendRequest(false, "img/waifu");
        
    }
}
