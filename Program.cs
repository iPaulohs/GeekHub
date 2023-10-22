using GeekHub.Commom;
using GeekHub.Database;
using GeekHub.Repository.FavoritesList_Repository;
using GeekHub.Repository.GeneralList;
using GeekHub.Repository.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GeekHubDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("GeekHubConnectionString")));
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<GeekHubDBContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICommomList, FavoritesListRepository>();
builder.Services.AddScoped<ICommomList, GeneralListRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
