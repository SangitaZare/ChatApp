# Chat

Real-time chat built on SignalR.

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

To start the frontend:

```bash
cd chat && npx @angular/cli new frontend --directory frontend
```

Repo: `github.com/SangitaZare/ChatApp`
