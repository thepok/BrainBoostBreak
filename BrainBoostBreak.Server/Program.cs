using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BrainBoostBreak.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .Build())
                .UseStartup<Startup>()
#if RELEASE
            .ConfigureKestrel(k=>k.ListenAnyIP(80))
#elif DEBUG
            .ConfigureKestrel(k => k.ListenAnyIP(55456))
#endif
                .Build();
    }
}
