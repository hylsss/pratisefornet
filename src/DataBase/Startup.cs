using DataBase.Data;
using Microsoft.EntityFrameworkCore;

namespace DataBase;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    public void ConfigureServices(IServiceCollection service)
    {
        service.AddControllers();
        service.AddDbContext<DataBaseContext>(option =>
            option.UseMySql(Configuration.GetConnectionString("Default"), new MySqlServerVersion(new Version(8, 0, 0)))
        );
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(enpoint => enpoint.MapControllers());
    }
}