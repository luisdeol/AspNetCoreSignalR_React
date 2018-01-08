# React message app + ASP.NET Core with SignalR


## Requirements

* [.NET Core 2.0](https://www.microsoft.com/net/learn/get-started/windows)
* [Node.js / npm](https://nodejs.org/en/)

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
