namespace ProjectIna;

public class Startup
{
    public void ConfigureServices(IServiceCollection service)
    {
        service.AddControllers();
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