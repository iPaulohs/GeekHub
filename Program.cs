using GeekHub.Commom;
using GeekHub.Database;
using GeekHub.Domains;
using GeekHub.Repository;
using GeekHub.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GeekHub.Repository.User;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GeekHubDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("GeekHubConnectionString")));
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<GeekHubDBContext>().AddDefaultTokenProviders();


builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICommomList, FavoritesListRepository>();
builder.Services.AddScoped<ICommomList, GeneralListRepository>();
builder.Services.AddScoped<HttpClient, HttpClient>();
builder.Services.AddScoped<HomeServices, HomeServices>();

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
