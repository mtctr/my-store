using MyStore.API.Modules;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterModules();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.MapEndpoints();
app.MapGet("/", () => "Hello World!");

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.Run();