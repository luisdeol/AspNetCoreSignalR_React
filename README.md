# React message app + ASP.NET Core with SignalR


## Requirements

* [.NET Core SDK](https://www.microsoft.com/net/download/thank-you/dotnet-sdk-2.1.3-windows-x64-installer)
* [Node.js / npm](https://nodejs.org/dist/v8.9.4/node-v8.9.4-x64.msi)

## Making things work

 

*cd* into the **AspNetCoreSignalR_React.Client** and run
```
npm install
npm run
```

*cd* into the **AspNetCoreSignalR_React.Server** folder and run

```
dotnet restore
dotnet run
```

You can change the chat room name by editing the *chatRoom* state propety in **Chat.js**.



Now you can open the *http://localhost:3000/* url in two tabs and check it out how the messages arrive in real-time from the SignalR Hub to the React app.
