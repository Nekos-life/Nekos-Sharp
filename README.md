# Nekos-Sharp
A C# lib for getting cute nekos, waifus and Foxes from nekos.life 

# How to use
Install the nuget package here https://www.nuget.org/packages/nekos-sharp

Create an instance of the client

```csharp
public static NekosSharp.NekoClient NekoClient = new NekoClient("Bot Name Here");`
```

Version 3 of nekos.life is here you can use them with
THIS HAS NOT BEEN UPDATED YET!
```csharp
Request Req = await NekoClient.Misc_v3.Cat();
Request Req = await NekoClient.Action_v3.Slap();
Request Req = await NekoClient.Image_v3.Neko();
Request Req = await NekoClient.Nsfw_v3.Neko();
```

Then use any of the endpoints
```csharp
Request Req = await NekoClient.Misc.Cat();
Request Req = await NekoClient.Action.Slap();
Request Req = await NekoClient.Image.Neko();
Request Req = await NekoClient.Nsfw.Neko();
```

`Misc endpoints: 5`

`Action endpoints: 8`

`Image endpoints: 10`

`Nsfw endpoints: 34 mmmhhh`


# Request
Req.ImageUrl | `The url of the requested image`

Req.Success | `Returns true if the request was successful`

Req.ErrorCode | `Error code of failed request`

Req.ErrorMessage | `Error message of failed request`

