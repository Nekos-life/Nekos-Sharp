using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NekosSharp
{
    /// <summary>
    /// Instance of nekos.life for getting cute waifus, nekos, foxes, cat and other images :3
    /// </summary>
    public class NekoClient
    {
        public NekoClient(string BotName)
        {
            Client.DefaultRequestHeaders.Add("User-Agent", $"Nekos-Sharp {Version} | {BotName}");
            Action = new ActionEndpoints(this);
            Misc = new MiscEndpoints(this);
            Image = new ImageEndpoints(this);
            Nsfw = new NsfwEndpoints(this);
            Action_v3 = new ActionEndpoints_v3(this);
            Misc_v3 = new MiscEndpoints_v3(this);
            Image_v3 = new ImageEndpoints_v3(this);
            Nsfw_v3 = new NsfwEndpoints_v3(this);
        }
        private readonly HttpClient Client = new HttpClient();
        public readonly string Version = "3.3";

        public LogType LogType = LogType.Info;
        public ActionEndpoints Action;
        public MiscEndpoints Misc;
        public ImageEndpoints Image;
        public NsfwEndpoints Nsfw;

        public ActionEndpoints_v3 Action_v3;
        public MiscEndpoints_v3 Misc_v3;
        public ImageEndpoints_v3 Image_v3;
        public NsfwEndpoints_v3 Nsfw_v3;

        /// <summary>
        /// https://nekos.life/api/v2/ + Url
        /// </summary>
        public async Task<Request> SendRequest(bool Usev3, string Url)
        {
            string Base = "https://nekos.life/api/v2/";
            if (Usev3)
                Base = "https://api.nekos.dev/api/v3/images/";
            Request Request = null;
            HttpResponseMessage Res = null;
            try
            {
                Res = await Client.GetAsync(Base + Url);
                Res.EnsureSuccessStatusCode();
                string Content = await Res.Content.ReadAsStringAsync();
                JObject Msg = JObject.Parse(Content);
                Request = new Request(Msg, true, "", (int)Res.StatusCode);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekosSharp] Success, {Request.ErrorMessage}");
                if (LogType == LogType.Debug)
                    Console.WriteLine("[NekoSharp] Request response in JSON\n" + Msg);
            }
            catch (Exception ex)
            {
                if (Res == null)
                    Request = new Request(null, false, ex.Message, 0);
                else
                    Request = new Request(null, false, ex.Message, (int)Res.StatusCode);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekosSharp] Failed, {Request.ErrorMessage} {Request.ErrorCode}");
                if (LogType == LogType.Debug)
                    Console.WriteLine("[NekosSharp] Exception\n" + ex.ToString());
            }
            return Request;
        } 
    }
    public enum LogType
    {
        None, Info, Debug
    }
    /// <summary>
    /// Response request from nekos.life with Success status and image url
    /// </summary>
    public class Request
    {
        public Request(JObject content, bool success, string error, int code)
        {
            if (content != null)
            {
                RawData = content;
                if (content.ContainsKey("url"))
                    ImageUrl = (string)content["url"];
                else if (content.ContainsKey("data"))
                {
                    ImageUrl = ((string)content["data"]["response"]["url"]).Replace("/ ", "/%20");
                }
            }
            Success = success;
            ErrorCode = code;
            ErrorMessage = error;
        }
        public readonly string ImageUrl;
        public readonly bool Success;
        public readonly int ErrorCode;
        public readonly string ErrorMessage;
        public readonly dynamic RawData;
    }
}
