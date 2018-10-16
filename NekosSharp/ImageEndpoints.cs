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
        public ImageEndpoints(NekosClient client)
        {
            Client = client;
        }

        private readonly NekosClient Client;
        private readonly string API = "https://nekos.life/api/v2/img/";

        public async Task<Request> Neko()
        {
            return await Client.SendRequest(API + "neko");
        }

        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(API + "ngif");
        }

        public async Task<Request> Fox()
        {
            return await Client.SendRequest(API + "fox_girl");
        }

        public async Task<Request> Smug()
        {
            return await Client.SendRequest(API + "smug");
        }

        public async Task<Request> Holo()
        {
            return await Client.SendRequest(API + "holo");
        }

        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(API + "avatar");
        }

        public async Task<Request> Wallpaper()
        {
            return await Client.SendRequest(API + "wallpaper");
        }

        public async Task<Request> Baka()
        {
            return await Client.SendRequest(API + "baka");
        }

        public async Task<Request> Waifu()
        {
            return await Client.SendRequest(API + "waifu");
        }
    }
}
