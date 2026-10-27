# Chat

Real-time chat built on an ASP.NET Core SignalR hub.

## Stack

**Backend** ASP.NET Core Web API · SignalR · MessagePack protocol · Redis backplane · JWT bearer authentication

## What it does

- **SignalR hub** (`ChatHub.cs`) pushing messages to connected clients over a persistent
  connection rather than polling
- **MessagePack protocol** — binary serialisation, so messages are smaller and faster to
  parse than the default JSON
- **Redis backplane** — lets the hub run behind more than one server instance and still
  deliver every message to every client, which plain in-memory SignalR cannot do
- **JWT-authenticated connections**, so a client identifies itself when it connects

## Layout

```
chat/
├─ backend/     .NET Web API + SignalR hub (ChatApp.Api)
└─ frontend/    empty — the Angular client is not scaffolded yet
```

The backend is committed (`ChatHub.cs`, `Controllers/`); the UI folder was created but
never filled.

## Run

```bash
# backend  →  https://localhost:7159
cd chat/backend && dotnet run
```

The hub can be exercised from a SignalR client or the `.http` file without a UI.

To start the frontend:

```bash
cd chat && npx @angular/cli new frontend --directory frontend
```
