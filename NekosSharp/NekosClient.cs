using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NekosSharp
{
    public class NekosClient
    {
        /// <summary>
        /// New instance of the NekosClient for getting cute neko pics :3
        /// </summary>
        public NekosClient(string BotName)
        {
            Client.DefaultRequestHeaders.Add("User-Agent", $"NekosSharp | {BotName}");
            Misc = new MiscEndpoints(this);
            Image = new ImageEndpoints(this);
            Nsfw = new NsfwEndpoints(this);
        }
        private readonly HttpClient Client = new HttpClient();
        public LogType LogType = LogType.Info;

        public MiscEndpoints Misc;
        public ImageEndpoints Image;
        public NsfwEndpoints Nsfw;

        internal async Task<Request> SendRequest(string Url)
        {
            Request Request = null;
            HttpResponseMessage Res = null;
            try
            {
                Res = await Client.GetAsync(Url);
                Res.EnsureSuccessStatusCode();
                string Content = await Res.Content.ReadAsStringAsync();
                JObject Msg = JObject.Parse(Content);
                Request = new Request((string)Msg["url"], true, "", (int)Res.StatusCode);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekosSharp] Success, {Request.ErrorMessage}");
                if (LogType == LogType.Debug)
                    Console.WriteLine("[NekoSharp] Request response in JSON\n" + Msg);
            }
            catch (Exception ex)
            {
                if (Res == null)
                    Request = new Request("", false, ex.Message, 0);
                else
                    Request = new Request("", false, ex.Message, (int)Res.StatusCode);
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
    public class Request
    {
        public Request(string imageurl, bool success, string error, int code)
        {
            ImageUrl = imageurl;
            Success = success;
            ErrorCode = code;
            ErrorMessage = error;
        }
        public readonly string ImageUrl;
        public readonly bool Success;
        public readonly int ErrorCode;
        public readonly string ErrorMessage;

    }
}
