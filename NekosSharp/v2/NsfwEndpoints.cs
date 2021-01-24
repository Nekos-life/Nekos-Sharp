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

        /// <summary>
        /// Abusive females but the good kind :eyes:
        /// </summary>
        public Task<Request> Femdom()
            => Client.SendRequest(false, "img/femdom");
        

        /// <summary>
        /// Classic hentai with no BS
        /// </summary>
        public Task<Request> ClassicGif()
            => Client.SendRequest(false, "img/classic");
        

        /// <summary>
        /// Foot fetish anyone?
        /// </summary>
        public Task<Request> Feet()
            => Client.SendRequest(false, "img/feet");
        

        /// <summary>
        /// Foot fetish anyone? with gifs!
        /// </summary>
        public Task<Request> FeetGif()
            => Client.SendRequest(false, "img/feetg");
        

        /// <summary>
        /// Very lewd nekos :3
        /// </summary>
        public Task<Request> Neko()
            => Client.SendRequest(false, "img/lewd");
        

        /// <summary>
        /// Very lewd nekos :3 with gifs!
        /// </summary>
        public Task<Request> NekoGif()
            => Client.SendRequest(false, "img/nsfw_neko_gif");
        

        /// <summary>
        /// Pussy lickin good
        /// </summary>
        public Task<Request> KuniGif()
            => Client.SendRequest(false, "img/kuni");
        

        /// <summary>
        /// Fondles those boobs :3
        /// </summary>
        public Task<Request> Boobs()
            => Client.SendRequest(false, "img/tits");
        

        /// <summary>
        /// Fondles those boobs with gifs :3 
        /// </summary>
        public Task<Request> BoobsGif()
            => Client.SendRequest(false, "img/boobs");
        

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks
        /// </summary>
        public Task<Request> Pussy()
            => Client.SendRequest(false, "img/pussy_jpg");
        

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks with gifs!
        /// </summary>
        public Task<Request> PussyGif()
            => Client.SendRequest(false, "img/pussy");
        

        /// <summary>
        /// HNNNGGGG
        /// </summary>
        public Task<Request> Cum()
            => Client.SendRequest(false, "img/cum_jpg");
        

        /// <summary>
        /// HNNNGGGG gifs
        /// </summary>
        public Task<Request> CumGif()
            => Client.SendRequest(false, "img/cum");
        

        /// <summary>
        /// Lewd spanking
        /// </summary>
        public Task<Request> Spank()
            => Client.SendRequest(false, "img/spank");
        

        /// <summary>
        /// UwU hentai pics
        /// </summary>
        public Task<Request> Hentai()
            => Client.SendRequest(false, "img/hentai");
        

        /// <summary>
        /// UwU hentai gifs
        /// </summary>
        public Task<Request> HentaiGif()
            => Client.SendRequest(false, "img/Random_hentai_gif");
        

        /// <summary>
        /// Very lewd avatars DEMONETIZED!
        /// </summary>
        public Task<Request> Avatar()
            => Client.SendRequest(false, "img/nsfw_avatar");
        

        /// <summary>
        /// One women band
        /// </summary>
        public Task<Request> Solo()
            => Client.SendRequest(false, "img/solo");
        

        /// <summary>
        /// One women band with gifs!
        /// </summary>
        public Task<Request> SoloGif()
            => Client.SendRequest(false, "img/solog");
        

        /// <summary>
        /// Give big succ
        /// </summary>
        public Task<Request> Blowjob()
            => Client.SendRequest(false, "img/blowjob");
        

        /// <summary>
        /// Give big succ with gifs!
        /// </summary>
        public Task<Request> BlowjobGif()
            => Client.SendRequest(false, "img/bj");
        

        /// <summary>
        /// Hot lewsbian couple
        /// </summary>
        public Task<Request> Yuri()
            => Client.SendRequest(false, "img/yuri");
        

        /// <summary>
        /// Hot lewsbian couple with gifs!
        /// </summary>
        public Task<Request> YuriGif()
            => Client.SendRequest(false, "img/les");
        

        /// <summary>
        /// Males dressed as female
        /// </summary>
        public Task<Request> Trap()
            => Client.SendRequest(false, "img/trap");
        

        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public Task<Request> AnalGif()
            => Client.SendRequest(false, "img/anal");
        

        /// <summary>
        /// (╯°□°）╯︵ ┻━┻
        /// </summary>
        public Task<Request> GasmAvatar()
            => Client.SendRequest(false, "img/gasm");
        

        /// <summary>
        /// Chicks with dicks go figure
        /// </summary>
        public Task<Request> Futanari()
            => Client.SendRequest(false, "img/futanari");
        

        /// <summary>
        /// Rubbin dat pussy
        /// </summary>
        public Task<Request> PwankGif()
            => Client.SendRequest(false, "img/pwankg");
        

        /// <summary>
        /// Slightly lewd waifus
        /// </summary>
        public Task<Request> Lewd()
            => Client.SendRequest(false, "img/ero");
        

        /// <summary>
        /// Slightly lewd yuri couple
        /// </summary>
        public Task<Request> LewdYuri()
            => Client.SendRequest(false, "img/eroyuri");

        /// <summary>
        /// Slightly lewd nekos girls
        /// </summary>
        public Task<Request> LewdNeko()
            => Client.SendRequest(false, "img/eron");
        

        /// <summary>
        /// Slightly lewd feet
        /// </summary>
        public Task<Request> LewdFeet()
            => Client.SendRequest(false, "img/erofeet");
        

        /// <summary>
        /// Slightly lewd holo 
        /// </summary>
        public Task<Request> LewdHolo()
            => Client.SendRequest(false, "img/hololewd");
        

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public Task<Request> LewdFox()
            => Client.SendRequest(false, "img/lewdk");
        
    }
}
