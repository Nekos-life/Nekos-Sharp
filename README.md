# Nekos-Sharp
A C# lib for getting cute nekos, waifus and Foxes from nekos.life 

# How to use
Install the nuget package here https://www.nuget.org/packages/nekos-sharp

Create an instance of the client

`public static NekosSharp.NekosClient NekoClient = new NekosClient("Bot Name Here");`

Then use any of the endpoints
```csharp
Request Req = await NekoClient.Image.Neko();
```

# Request
Req.ImageUrl | `The url of the requested image`

Req.Success | `Returns true if the request was successful`

Req.ErrorCode | `Error code of failed request`

Req.ErrorMessage | `Error message of failed request`

