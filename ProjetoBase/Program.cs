using Microsoft.EntityFrameworkCore;
using ProjetoBase.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Adicionando o serviço de entidade do Framework SQL Server
builder.Services.AddEntityFrameworkSqlServer();
//adicionando o serviço do DbContext, injetando a string de conexão. De acordo com o appsettings.json
builder.Services.AddDbContext<BancoContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Demonstrativo}/{id?}");

app.Run();
