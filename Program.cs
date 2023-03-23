using Microsoft.EntityFrameworkCore;
using UserDetails_API.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<UserDetails_APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserDetails_APIContext") ?? throw new InvalidOperationException("Connection string 'UserDetails_APIContext' not found.")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();

app.Run();