using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProjectIna;

namespace  ProjectIna;

public class Program
{
    
    public static void Test1()
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<UserInfo, UserInfoDto>());
    }


    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }
    
    
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}