using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Very nsfw commands do not run these in a non-nsfw channel!
    /// </summary>
    public class NsfwEndpoints_v3
    {
        public NsfwEndpoints_v3(NekoClient client)
        {
            Client = client;
        }
        private readonly NekoClient Client;

        /// <summary>
        /// Abusive females but the good kind :eyes:
        /// </summary>
        public async Task<Request> Ahegao()
        {
            return await Client.SendRequest(true, "nsfw/img/ahegao_avatar");
        }


        /// <summary>
        /// Abusive females but the good kind :eyes:
        /// </summary>
        public async Task<Request> Femdom()
        {
            return await Client.SendRequest(true, "nsfw/img/femdom_lewd");
        }

        /// <summary>
        /// Lewd dress up
        /// </summary>
        public async Task<Request> Cosplay()
        {
            return await Client.SendRequest(true, "nsfw/img/cosplay_lewd");
        }

        /// <summary>
        /// Classic hentai no BS
        /// </summary>
        public async Task<Request> Classic()
        {
            return await Client.SendRequest(true, "nsfw/img/classic_lewd");
        }

        /// <summary>
        /// Classic hentai with no BS with gifs
        /// </summary>
        public async Task<Request> ClassicGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/classic");
        }

        /// <summary>
        /// Foot fetish anyone?
        /// </summary>
        public async Task<Request> Feet()
        {
            return await Client.SendRequest(true, "nsfw/img/feet_lewd");
        }

        /// <summary>
        /// Foot fetish anyone? with gifs!
        /// </summary>
        public async Task<Request> FeetGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/feet");
        }

        /// <summary>
        /// Very lewd nekos :3
        /// </summary>
        public async Task<Request> Neko()
        {
            return await Client.SendRequest(true, "nsfw/img/neko_lewd");
        }

        /// <summary>
        /// Slightly lewd nekos girls
        /// </summary>
        public async Task<Request> EroNeko()
        {
            return await Client.SendRequest(true, "nsfw/img/neko_ero");
        }

        /// <summary>
        /// Very lewd nekos :3 with gifs!
        /// </summary>
        public async Task<Request> NekoGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/neko");
        }

        /// <summary>
        /// Pussy lickin good
        /// </summary>
        public async Task<Request> KuniGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/kuni");
        }

        /// <summary>
        /// Fondles those boobs :3
        /// </summary>
        public async Task<Request> Boobs()
        {
            return await Client.SendRequest(true, "nsfw/img/tits_lewd");
        }

        /// <summary>
        /// Fondles those boobs with gifs :3 
        /// </summary>
        public async Task<Request> BoobsGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/tits");
        }

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks
        /// </summary>
        public async Task<Request> Pussy()
        {
            return await Client.SendRequest(true, "nsfw/img/pussy_lewd");
        }

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks with gifs!
        /// </summary>
        public async Task<Request> PussyGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/pussy");
        }

        /// <summary>
        /// HNNNGGGG
        /// </summary>
        public async Task<Request> Cum()
        {
            return await Client.SendRequest(true, "nsfw/img/cum_lewd");
        }

        /// <summary>
        /// HNNNGGGG gifs
        /// </summary>
        public async Task<Request> CumGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/cum");
        }

        /// <summary>
        /// Lewd spanking
        /// </summary>
        public async Task<Request> SpankGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/spank");
        }

        /// <summary>
        /// Slightly lewd hentai
        /// </summary>
        public async Task<Request> Lewd()
        {
            return await Client.SendRequest(true, "nsfw/img/all_tags_ero");
        }

        /// <summary>
        /// UwU hentai pics
        /// </summary>
        public async Task<Request> Hentai()
        {
            return await Client.SendRequest(true, "nsfw/img/all_tags_lewd");
        }

        /// <summary>
        /// UwU hentai gifs
        /// </summary>
        public async Task<Request> HentaiGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/all_tags");
        }

        /// <summary>
        /// One women band
        /// </summary>
        public async Task<Request> Solo()
        {
            return await Client.SendRequest(true, "nsfw/img/solo_lewd");
        }

        /// <summary>
        /// One women band with gifs!
        /// </summary>
        public async Task<Request> SoloGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/girls_solo");
        }

        /// <summary>
        /// Give big succ
        /// </summary>
        public async Task<Request> Blowjob()
        {
            return await Client.SendRequest(true, "nsfw/img/blowjob_lewd");
        }

        /// <summary>
        /// Give big succ with gifs!
        /// </summary>
        public async Task<Request> BlowjobGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/blow_job");
        }

        /// <summary>
        /// Hot lewsbian couple
        /// </summary>
        public async Task<Request> Yuri()
        {
            return await Client.SendRequest(true, "nsfw/img/yuri_lewd");
        }

        /// <summary>
        /// Hot lewsbian couple with gifs!
        /// </summary>
        public async Task<Request> YuriGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/yuri");
        }

        /// <summary>
        /// Males dressed as female
        /// </summary>
        public async Task<Request> Trap()
        {
            return await Client.SendRequest(true, "nsfw/img/trap_lewd");
        }

        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public async Task<Request> Anal()
        {
            return await Client.SendRequest(true, "nsfw/img/anal_lewd");
        }

        /// <summary>
        /// Slightly lewd wallpapers
        /// </summary>
        public async Task<Request> EroWallpaper()
        {
            return await Client.SendRequest(true, "nsfw/img/ero_wallpaper_ero");
        }

        /// <summary>
        /// Lewd wallpapers
        /// </summary>
        public async Task<Request> Wallpaper()
        {
            return await Client.SendRequest(true, "nsfw/img/wallpaper_lewd");
        }


        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public async Task<Request> Anus()
        {
            return await Client.SendRequest(true, "nsfw/img/anus_lewd");
        }

        /// <summary>
        /// An alternative hole? what madness with gifs
        /// </summary>
        public async Task<Request> AnalGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/anal");
        }

        /// <summary>
        /// Chicks with dicks go figure
        /// </summary>
        public async Task<Request> Futanari()
        {
            return await Client.SendRequest(true, "nsfw/img/futanari_lewd");
        }

        /// <summary>
        /// Rubbin dat pussy
        /// </summary>
        public async Task<Request> PwankGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/pussy_wank");
        }

        /// <summary>
        /// Bondage stuff mmmhh hot
        /// </summary>
        public async Task<Request> Bdsm()
        {
            return await Client.SendRequest(true, "nsfw/img/bdsm_lewd");
        }

        /// <summary>
        /// Slightly lewd yuri couple
        /// </summary>
        public async Task<Request> EroYuri()
        {
            return await Client.SendRequest(true, "nsfw/img/yuri_ero");
        }

        /// <summary>
        /// Slightly lewd feet
        /// </summary>
        public async Task<Request> EroFeet()
        {
            return await Client.SendRequest(true, "nsfw/img/feet_ero");
        }

        /// <summary>
        /// Lewd holo 
        /// </summary>
        public async Task<Request> Holo()
        {
            return await Client.SendRequest(true, "nsfw/img/holo_lewd");
        }

        /// <summary>
        /// Lewd holo avatar
        /// </summary>
        public async Task<Request> HoloAvatar()
        {
            return await Client.SendRequest(true, "nsfw/img/holo_avatar");
        }

        /// <summary>
        /// Slightly lewd holo 
        /// </summary>
        public async Task<Request> EroHolo()
        {
            return await Client.SendRequest(true, "nsfw/img/holo_ero");
        }

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public async Task<Request> Fox()
        {
            return await Client.SendRequest(true, "nsfw/img/kitsune_lewd");
        }

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public async Task<Request> EroFox()
        {
            return await Client.SendRequest(true, "nsfw/img/kitsune_ero");
        }

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public async Task<Request> Fox2()
        {
            return await Client.SendRequest(true, "nsfw/img/kemonomimi_lewd");
        }

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public async Task<Request> EroFox2()
        {
            return await Client.SendRequest(true, "nsfw/img/kemonomimi_ero");
        }

        /// <summary>
        /// Lewd stockings
        /// </summary>
        public async Task<Request> Pantyhose()
        {
            return await Client.SendRequest(true, "nsfw/img/pantyhose_lewd");
        }

        /// <summary>
        /// Slightly lewd stockings
        /// </summary>
        public async Task<Request> EroPantyhose()
        {
            return await Client.SendRequest(true, "nsfw/img/pantyhose_ero");
        }

        /// <summary>
        /// Lewd piersings
        /// </summary>
        public async Task<Request> Piersing()
        {
            return await Client.SendRequest(true, "nsfw/img/piersing_lewd");
        }

        /// <summary>
        /// Slightly lewd piersings
        /// </summary>
        public async Task<Request> EroPiersing()
        {
            return await Client.SendRequest(true, "nsfw/img/piersing_ero");
        }

        /// <summary>
        /// Lewd peeing sssss
        /// </summary>
        public async Task<Request> Peeing()
        {
            return await Client.SendRequest(true, "nsfw/img/peeing_lewd");
        }

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public async Task<Request> Keta()
        {
            return await Client.SendRequest(true, "nsfw/img/keta_lewd");
        }

        /// <summary>
        /// Small boob girls
        /// </summary>
        public async Task<Request> SmallBoobs()
        {
            return await Client.SendRequest(true, "nsfw/img/smallboobs_lewd");
        }

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public async Task<Request> KetaAvatar()
        {
            return await Client.SendRequest(true, "nsfw/img/keta_avatar");
        }

        /// <summary>
        /// Iff ya furrys
        /// </summary>
        public async Task<Request> Yiff()
        {
            return await Client.SendRequest(true, "nsfw/img/yiff_lewd");
        }

        /// <summary>
        /// Yiff ya furrys with gifs
        /// </summary>
        public async Task<Request> YiffGif()
        {
            return await Client.SendRequest(true, "nsfw/gif/yiff");
        }
    }
}
