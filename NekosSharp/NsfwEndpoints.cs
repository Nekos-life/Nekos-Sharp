using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    public class NsfwEndpoints
    {
        public NsfwEndpoints(NekosClient client)
        {
            Client = client;
        }
        private readonly NekosClient Client;
        private readonly string API = "https://nekos.life/api/v2/img/";

        /// <summary>
        /// Abusive females but the good kind :eyes:
        /// </summary>
        public async Task<Request> Femdom()
        {
            return await Client.SendRequest(API + "femdom");
        }

        /// <summary>
        /// Classic hentai with no BS
        /// </summary>
        public async Task<Request> Classic()
        {
            return await Client.SendRequest(API + "classic");
        }

        public async Task<Request> Lesbian()
        {
            return await Client.SendRequest(API + "les");
        }

        public async Task<Request> Feet()
        {
            return await Client.SendRequest(API + "feet");
        }

        public async Task<Request> FeetGif()
        {
            return await Client.SendRequest(API + "feetg");
        }

        public async Task<Request> Neko()
        {
            return await Client.SendRequest(API + "lewd");
        }

        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(API + "nsfw_neko_gif");
        }

        public async Task<Request> KuniGif()
        {
            return await Client.SendRequest(API + "kuni");
        }

        public async Task<Request> Boobs()
        {
            return await Client.SendRequest(API + "tits");
        }

        public async Task<Request> BoobsGif()
        {
            return await Client.SendRequest(API + "boobs");
        }

        public async Task<Request> Pussy()
        {
            return await Client.SendRequest(API + "pussy_jpg");
        }

        public async Task<Request> PussyGif()
        {
            return await Client.SendRequest(API + "pussy");
        }

        public async Task<Request> Cum()
        {
            return await Client.SendRequest(API + "cum_jpg");
        }

        public async Task<Request> CumGif()
        {
            return await Client.SendRequest(API + "cum");
        }

        public async Task<Request> Spank()
        {
            return await Client.SendRequest(API + "spank");
        }

        public async Task<Request> Flat()
        {
            return await Client.SendRequest(API + "smallboobs");
        }

        public async Task<Request> Hentai()
        {
            return await Client.SendRequest(API + "hentai");
        }

        public async Task<Request> HentaiGif()
        {
            return await Client.SendRequest(API + "Random_hentai_gif");
        }

        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(API + "nsfw_avatar");
        }
        
        public async Task<Request> Solo()
        {
            return await Client.SendRequest(API + "solo");
        }

        public async Task<Request> SoloGif()
        {
            return await Client.SendRequest(API + "solog");
        }

        public async Task<Request> BlowjobGif()
        {
            return await Client.SendRequest(API + "bj");
        }

        public async Task<Request> Blowjob()
        {
            return await Client.SendRequest(API + "blowjob");
        }

        public async Task<Request> Yuri()
        {
            return await Client.SendRequest(API + "yuri");
        }

        public async Task<Request> Trap()
        {
            return await Client.SendRequest(API + "trap");
        }

        public async Task<Request> AnalGif()
        {
            return await Client.SendRequest(API + "anal");
        }

        public async Task<Request> GasmAvatar()
        {
            return await Client.SendRequest(API + "gasm");
        }
        
        public async Task<Request> Futanari()
        {
            return await Client.SendRequest(API + "futanari");
        }

        public async Task<Request> PwankGif()
        {
            return await Client.SendRequest(API + "pwankg");
        }

        public async Task<Request> Lewd()
        {
            return await Client.SendRequest(API + "ero");
        }

        public async Task<Request> LewdYuri()
        {
            return await Client.SendRequest(API + "eroyuri");
        }

        public async Task<Request> LewdNeko()
        {
            return await Client.SendRequest(API + "eron");
        }

        public async Task<Request> LewdFeet()
        {
            return await Client.SendRequest(API + "erofeet");
        }

        public async Task<Request> LewdHolo()
        {
            return await Client.SendRequest(API + "hololewd");
        }

        public async Task<Request> LewdFox()
        {
            return await Client.SendRequest(API + "lewdk");
        }
    }
}
