using Microsoft.EntityFrameworkCore;
using SPManager_Backend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var origenesPermitidos = builder.Configuration.GetValue<string>("OrigenesPermitidos")!.Split(',');

#region Configuracion de CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(politica =>
    {
        politica.WithOrigins(origenesPermitidos).AllowAnyHeader().AllowAnyMethod();
    });
});
#endregion

#region Configuracion de la base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SPManagerConnection"));
});
#endregion

var app = builder.Build();

#region Base de datos Automatica
//mantiene actualizada la base de datos automaticamente, pueden probarlo, sino sigan las instrucciones en el Readme.md
/*
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}
*/
#endregion

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Activa CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
