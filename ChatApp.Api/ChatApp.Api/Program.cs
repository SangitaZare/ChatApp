using ChatApp.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ng", policy => policy
        .WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials());
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("ng");          // must come before MapHub
app.MapControllers();
app.MapHub<ChatHub>("/chathub");

app.Run();