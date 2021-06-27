using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
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
            if (Client == null)
            {
                Client = new HttpClient();
                Json = new JsonSerializer();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Client.DefaultRequestHeaders.Add("User-Agent", $"Nekos-Sharp {Version} | {BotName}");
            }
            Action = new ActionEndpoints(this);
            Misc = new MiscEndpoints(this);
            Image = new ImageEndpoints(this);
            Nsfw = new NsfwEndpoints(this);
            Action_v3 = new ActionEndpoints_v3(this);
            Misc_v3 = new MiscEndpoints_v3(this);
            Image_v3 = new ImageEndpoints_v3(this);
            Nsfw_v3 = new NsfwEndpoints_v3(this);
        }
        private static HttpClient Client;
        public static readonly string Version = "3.5.0";
        private static JsonSerializer Json;

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
        public async Task<Request> SendRequest(bool Usev3, string Url, int Count = 1)
        {
            string Base = "https://nekos.life/api/v2/" + Url;
            if (Usev3)
            {
                Base = "https://api.nekos.dev/api/v3/images/" + Url;
                if (Count != 1)
                    Base += Base + $"?count={Count}";
            }
            Request Request = null;
            HttpResponseMessage Res = null;
            try
            {
                Res = await Client.GetAsync(Base, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
                Res.EnsureSuccessStatusCode();
                Stream Stream = await Res.Content.ReadAsStreamAsync().ConfigureAwait(false);
                using (TextReader text = new StreamReader(Stream))
                using (JsonReader reader = new JsonTextReader(text))
                {
                    JToken Value = await JObject.ReadFromAsync(reader).ConfigureAwait(false);
                    if ((string)Value["status"]["code"] != 200)
                        throw new Exception("Returned JSON status code is not 200");
                    if (Usev3)
                        Request = new Request("", 200) { ImageUrl = (string)Value["data"]["response"]["url"] };
                    else
                        Request = new Request("", 200) { ImageUrl = (string)Value["url"] };
                }
                switch (LogType)
                {
                    case LogType.Info:
                        Console.WriteLine($"[NekosSharp] Success, {Request.Error}");
                        break;
                    case LogType.Debug:
                        Console.WriteLine($"[NekosSharp] Success, {Request.Error}");
                        Console.WriteLine("[NekosSharp] Request response in JSON\n" + JsonConvert.SerializeObject(Request, Formatting.Indented));
                        break;
                }
            }
            catch (Exception ex)
            {
                if (Res == null)
                    Request = new Request(ex.Message, 0);
                else
                    Request = new Request(ex.Message, (int)Res.StatusCode);
                switch (LogType)
                {
                    case LogType.Info:
                        Console.WriteLine($"[NekosSharp] Failed, {Request.Error} {Request.Code}");
                        break;
                    case LogType.Debug:
                        Console.WriteLine($"[NekosSharp] Failed, {Request.Error} {Request.Code}");
                        Console.WriteLine("[NekosSharp] Exception\n" + ex.ToString());
                        break;
                }
            }
            if (Request == null)
            {
                Request = new Request("Failed to parse json response", 400);
                if (LogType >= LogType.Info)
                    Console.WriteLine($"[NekosSharp] Failed to parse json response");
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
        public Request(string error = "", int code = 0)
        {
            if (code == 200)
                Success = true;
            Code = code;
            Error = error;
        }
        public string ImageUrl { get; internal set; }
        public bool Success { get; internal set; }
        public int Code { get; private set; }
        public string Error{ get; private set; }
    }
}
