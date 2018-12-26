# Nekos-Sharp
A C# lib for getting cute nekos, waifus and Foxes from nekos.life 

# How to use
Install the nuget package here https://www.nuget.org/packages/nekos-sharp

Create an instance of the client

```csharp
public static NekosSharp.NekosClient NekoClient = new NekosClient("Bot Name Here");`
```

Then use any of the endpoints
```csharp
Request Req = await NekoClient.Misc.Cat();
Request Req = await NekoClient.Action.Slap();
Request Req = await NekoClient.Image.Neko();
Request Req = await NekoClient.Nsfw.Neko();
```

`Misc endpoints: 3`

`Action endpoints: 8`

`Image endpoints: 10`

`Nsfw endpoints: 35 mmmhhh`


# Request
Req.ImageUrl | `The url of the requested image`

Req.Success | `Returns true if the request was successful`

Req.ErrorCode | `Error code of failed request`

Req.ErrorMessage | `Error message of failed request`

