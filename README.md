# React message app + ASP.NET Core with SignalR



To try it out: 

*cd* into the **AspNetCoreSignalR_React.Client** folder and run
```
npm install
npm run
```

cd into the **AspNetCoreSignalR_React.Server** folder and run

```
dotnet restore
dotnet run
```

You can change the chat room name by editing the *chatRoom* state propety in **Chat.js**.



Now you can open the *http://localhost:3000/ url in two tabs and check it out how the messages arrive in real-time from the SignalR Hub to the React app.S
