using GhumakkadAPI.Database;
using GhumakkadAPI.Manager;
using GhumakkadAPI.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<GhumakkadContext>(t=>t.UseSqlServer(builder.Configuration.GetConnectionString("Connectionstring")));
// Add services to the container.
// AddTransient(),AddScoped(),AddSingleton() ?
builder.Services.AddScoped<IArticleService,ArticleService>();
builder.Services.AddScoped<IArticleManager,ArticleManager>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
