using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Very nsfw commands do not run these in a non-nsfw channel!
    /// </summary>
    public class NsfwEndpoints
    {
        public NsfwEndpoints(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;
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
        public async Task<Request> ClassicGif()
        {
            return await Client.SendRequest(API + "classic");
        }

        /// <summary>
        /// Foot fetish anyone?
        /// </summary>
        public async Task<Request> Feet()
        {
            return await Client.SendRequest(API + "feet");
        }

        /// <summary>
        /// Foot fetish anyone? with gifs!
        /// </summary>
        public async Task<Request> FeetGif()
        {
            return await Client.SendRequest(API + "feetg");
        }

        /// <summary>
        /// Very lewd nekos :3
        /// </summary>
        public async Task<Request> Neko()
        {
            return await Client.SendRequest(API + "lewd");
        }

        /// <summary>
        /// Very lewd nekos :3 with gifs!
        /// </summary>
        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(API + "nsfw_neko_gif");
        }

        /// <summary>
        /// Pussy lickin good
        /// </summary>
        public async Task<Request> KuniGif()
        {
            return await Client.SendRequest(API + "kuni");
        }

        /// <summary>
        /// Fondles those boobs :3
        /// </summary>
        public async Task<Request> Boobs()
        {
            return await Client.SendRequest(API + "tits");
        }

        /// <summary>
        /// Fondles those boobs with gifs :3 
        /// </summary>
        public async Task<Request> BoobsGif()
        {
            return await Client.SendRequest(API + "boobs");
        }

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks
        /// </summary>
        public async Task<Request> Pussy()
        {
            return await Client.SendRequest(API + "pussy_jpg");
        }

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks with gifs!
        /// </summary>
        public async Task<Request> PussyGif()
        {
            return await Client.SendRequest(API + "pussy");
        }

        /// <summary>
        /// HNNNGGGG
        /// </summary>
        public async Task<Request> Cum()
        {
            return await Client.SendRequest(API + "cum_jpg");
        }

        /// <summary>
        /// HNNNGGGG gifs
        /// </summary>
        public async Task<Request> CumGif()
        {
            return await Client.SendRequest(API + "cum");
        }

        /// <summary>
        /// Lewd spanking
        /// </summary>
        public async Task<Request> Spank()
        {
            return await Client.SendRequest(API + "spank");
        }

        /// <summary>
        /// Flat as a chess board
        /// </summary>
        public async Task<Request> Flat()
        {
            return await Client.SendRequest(API + "smallboobs");
        }

        /// <summary>
        /// UwU hentai pics
        /// </summary>
        public async Task<Request> Hentai()
        {
            return await Client.SendRequest(API + "hentai");
        }

        /// <summary>
        /// UwU hentai gifs
        /// </summary>
        public async Task<Request> HentaiGif()
        {
            return await Client.SendRequest(API + "Random_hentai_gif");
        }

        /// <summary>
        /// Very lewd avatars DEMONETIZED!
        /// </summary>
        public async Task<Request> Avatar()
        {
            return await Client.SendRequest(API + "nsfw_avatar");
        }

        /// <summary>
        /// One women band
        /// </summary>
        public async Task<Request> Solo()
        {
            return await Client.SendRequest(API + "solo");
        }

        /// <summary>
        /// One women band with gifs!
        /// </summary>
        public async Task<Request> SoloGif()
        {
            return await Client.SendRequest(API + "solog");
        }

        /// <summary>
        /// Give big succ
        /// </summary>
        public async Task<Request> Blowjob()
        {
            return await Client.SendRequest(API + "blowjob");
        }

        /// <summary>
        /// Give big succ with gifs!
        /// </summary>
        public async Task<Request> BlowjobGif()
        {
            return await Client.SendRequest(API + "bj");
        }

        /// <summary>
        /// Hot lewsbian couple
        /// </summary>
        public async Task<Request> Yuri()
        {
            return await Client.SendRequest(API + "yuri");
        }

        /// <summary>
        /// Hot lewsbian couple with gifs!
        /// </summary>
        public async Task<Request> YuriGif()
        {
            return await Client.SendRequest(API + "les");
        }

        /// <summary>
        /// Males dressed as female
        /// </summary>
        public async Task<Request> Trap()
        {
            return await Client.SendRequest(API + "trap");
        }

        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public async Task<Request> AnalGif()
        {
            return await Client.SendRequest(API + "anal");
        }

        /// <summary>
        /// (╯°□°）╯︵ ┻━┻
        /// </summary>
        public async Task<Request> GasmAvatar()
        {
            return await Client.SendRequest(API + "gasm");
        }

        /// <summary>
        /// Chicks with dicks go figure
        /// </summary>
        public async Task<Request> Futanari()
        {
            return await Client.SendRequest(API + "futanari");
        }

        /// <summary>
        /// Rubbin dat pussy
        /// </summary>
        public async Task<Request> PwankGif()
        {
            return await Client.SendRequest(API + "pwankg");
        }

        /// <summary>
        /// Slightly lewd waifus
        /// </summary>
        public async Task<Request> Lewd()
        {
            return await Client.SendRequest(API + "ero");
        }

        /// <summary>
        /// Slightly lewd yuri couple
        /// </summary>
        public async Task<Request> LewdYuri()
        {
            return await Client.SendRequest(API + "eroyuri");
        }

        /// <summary>
        /// Slightly lewd nekos girls
        /// </summary>
        public async Task<Request> LewdNeko()
        {
            return await Client.SendRequest(API + "eron");
        }

        /// <summary>
        /// Slightly lewd feet
        /// </summary>
        public async Task<Request> LewdFeet()
        {
            return await Client.SendRequest(API + "erofeet");
        }

        /// <summary>
        /// Slightly lewd holo 
        /// </summary>
        public async Task<Request> LewdHolo()
        {
            return await Client.SendRequest(API + "hololewd");
        }

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public async Task<Request> LewdFox()
        {
            return await Client.SendRequest(API + "lewdk");
        }
    }
}
