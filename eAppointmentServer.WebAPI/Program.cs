using eAppointmentServer.Application;
using eAppointmentServer.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//  CORS service kaydý
builder.Services.AddCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//  CORS middleware (ÇOK ÖNEMLÝ: Authorization'dan ÖNCE)
app.UseCors(x => x
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
    .SetIsOriginAllowed(_ => true));

app.UseAuthorization();

app.MapControllers();

app.Run();
