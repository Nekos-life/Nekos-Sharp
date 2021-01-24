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
        public Task<Request> Ahegao(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/ahegao_avatar", Count);
        


        /// <summary>
        /// Abusive females but the good kind :eyes:
        /// </summary>
        public Task<Request> Femdom(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/femdom_lewd", Count);
        

        /// <summary>
        /// Lewd dress up
        /// </summary>
        public Task<Request> Cosplay(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/cosplay_lewd", Count);
        

        /// <summary>
        /// Classic hentai no BS
        /// </summary>
        public Task<Request> Classic(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/classic_lewd", Count);
        

        /// <summary>
        /// Classic hentai with no BS with gifs
        /// </summary>
        public Task<Request> ClassicGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/classic", Count);
        

        /// <summary>
        /// Foot fetish anyone?
        /// </summary>
        public Task<Request> Feet(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/feet_lewd", Count);
        

        /// <summary>
        /// Foot fetish anyone? with gifs!
        /// </summary>
        public Task<Request> FeetGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/feet", Count);
        

        /// <summary>
        /// Very lewd nekos :3
        /// </summary>
        public Task<Request> Neko(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/neko_lewd", Count);
        

        /// <summary>
        /// Slightly lewd nekos girls
        /// </summary>
        public Task<Request> EroNeko(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/neko_ero", Count);
        

        /// <summary>
        /// Very lewd nekos :3 with gifs!
        /// </summary>
        public Task<Request> NekoGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/neko", Count);
        

        /// <summary>
        /// Pussy lickin good
        /// </summary>
        public Task<Request> KuniGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/kuni", Count);
        

        /// <summary>
        /// Fondles those boobs :3
        /// </summary>
        public Task<Request> Boobs(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/tits_lewd", Count);
        

        /// <summary>
        /// Fondles those boobs with gifs :3 
        /// </summary>
        public Task<Request> BoobsGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/tits", Count);
        

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks
        /// </summary>
        public Task<Request> Pussy(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/pussy_lewd", Count);
        

        /// <summary>
        /// Slaps roof of pussy, this hole can fit so many dicks with gifs!
        /// </summary>
        public Task<Request> PussyGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/pussy", Count);
        

        /// <summary>
        /// HNNNGGGG
        /// </summary>
        public Task<Request> Cum(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/cum_lewd", Count);
        

        /// <summary>
        /// HNNNGGGG gifs
        /// </summary>
        public Task<Request> CumGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/cum", Count);
        

        /// <summary>
        /// Lewd spanking
        /// </summary>
        public Task<Request> SpankGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/spank", Count);
        

        /// <summary>
        /// Slightly lewd hentai
        /// </summary>
        public Task<Request> Lewd(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/all_tags_ero", Count);
        

        /// <summary>
        /// UwU hentai pics
        /// </summary>
        public Task<Request> Hentai(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/all_tags_lewd", Count);
        

        /// <summary>
        /// UwU hentai gifs
        /// </summary>
        public Task<Request> HentaiGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/all_tags", Count);
        

        /// <summary>
        /// One women band
        /// </summary>
        public Task<Request> Solo(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/solo_lewd", Count);
        

        /// <summary>
        /// One women band with gifs!
        /// </summary>
        public Task<Request> SoloGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/girls_solo", Count);
        

        /// <summary>
        /// Give big succ
        /// </summary>
        public Task<Request> Blowjob(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/blowjob_lewd", Count);
        

        /// <summary>
        /// Give big succ with gifs!
        /// </summary>
        public Task<Request> BlowjobGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/blow_job", Count);
        

        /// <summary>
        /// Hot lewsbian couple
        /// </summary>
        public Task<Request> Yuri(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/yuri_lewd", Count);
        

        /// <summary>
        /// Hot lewsbian couple with gifs!
        /// </summary>
        public Task<Request> YuriGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/yuri", Count);
        

        /// <summary>
        /// Males dressed as female
        /// </summary>
        public Task<Request> Trap(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/trap_lewd", Count);
        

        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public Task<Request> Anal(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/anal_lewd", Count);
        

        /// <summary>
        /// Slightly lewd wallpapers
        /// </summary>
        public Task<Request> EroWallpaper(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/ero_wallpaper_ero", Count);
        

        /// <summary>
        /// Lewd wallpapers
        /// </summary>
        public Task<Request> Wallpaper(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/wallpaper_lewd", Count);
        


        /// <summary>
        /// An alternative hole? what madness
        /// </summary>
        public Task<Request> Anus(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/anus_lewd", Count);
        

        /// <summary>
        /// An alternative hole? what madness with gifs
        /// </summary>
        public Task<Request> AnalGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/anal", Count);
        

        /// <summary>
        /// Chicks with dicks go figure
        /// </summary>
        public Task<Request> Futanari(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/futanari_lewd", Count);
        

        /// <summary>
        /// Rubbin dat pussy
        /// </summary>
        public Task<Request> PwankGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/pussy_wank", Count);
        

        /// <summary>
        /// Bondage stuff mmmhh hot
        /// </summary>
        public Task<Request> Bdsm(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/bdsm_lewd", Count);
        

        /// <summary>
        /// Slightly lewd yuri couple
        /// </summary>
        public Task<Request> EroYuri(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/yuri_ero", Count);
        

        /// <summary>
        /// Slightly lewd feet
        /// </summary>
        public Task<Request> EroFeet(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/feet_ero", Count);
        

        /// <summary>
        /// Lewd holo 
        /// </summary>
        public Task<Request> Holo(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/holo_lewd", Count);
        

        /// <summary>
        /// Lewd holo avatar
        /// </summary>
        public Task<Request> HoloAvatar(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/holo_avatar", Count);
        

        /// <summary>
        /// Slightly lewd holo 
        /// </summary>
        public Task<Request> EroHolo(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/holo_ero", Count);
        

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public Task<Request> Fox(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/kitsune_lewd", Count);
        

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public Task<Request> EroFox(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/kitsune_ero", Count);
        

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public Task<Request> Fox2(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/kemonomimi_lewd", Count);
        

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public Task<Request> EroFox2(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/kemonomimi_ero", Count);
        

        /// <summary>
        /// Lewd stockings
        /// </summary>
        public Task<Request> Pantyhose(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/pantyhose_lewd", Count);
        

        /// <summary>
        /// Slightly lewd stockings
        /// </summary>
        public Task<Request> EroPantyhose(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/pantyhose_ero", Count);
        

        /// <summary>
        /// Lewd piersings
        /// </summary>
        public Task<Request> Piersing(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/piersing_lewd", Count);
        

        /// <summary>
        /// Slightly lewd piersings
        /// </summary>
        public Task<Request> EroPiersing(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/piersing_ero", Count);
        

        /// <summary>
        /// Lewd peeing sssss
        /// </summary>
        public Task<Request> Peeing(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/peeing_lewd", Count);
        

        /// <summary>
        /// Lewd fox girls
        /// </summary>
        public Task<Request> Keta(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/keta_lewd", Count);
        

        /// <summary>
        /// Small boob girls
        /// </summary>
        public Task<Request> SmallBoobs(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/smallboobs_lewd", Count);
        

        /// <summary>
        /// Slightly lewd fox girls
        /// </summary>
        public Task<Request> KetaAvatar(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/keta_avatar", Count);
        

        /// <summary>
        /// Iff ya furrys
        /// </summary>
        public Task<Request> Yiff(int Count = 1)
            => Client.SendRequest(true, "nsfw/img/yiff_lewd", Count);
        

        /// <summary>
        /// Yiff ya furrys with gifs
        /// </summary>
        public Task<Request> YiffGif(int Count = 1)
            => Client.SendRequest(true, "nsfw/gif/yiff", Count);
        
    }
}
