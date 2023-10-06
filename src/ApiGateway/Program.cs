using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

public class Program
{
    public static void Main(string[] args)
    {
        BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args)
    {
        var builder = WebHost.CreateDefaultBuilder(args);

        builder.ConfigureServices(s => s.AddSingleton(builder))
                .ConfigureAppConfiguration(
                      ic => ic.AddJsonFile(Path.Combine("configuration",
                                                        "configuration.json")));
                
        var host = builder.Build();
        return host;
    }
}