using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var config = new ConfigurationBuilder()
				.AddCommandLine(args)
				.Build();

            var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseConfiguration(config)
				.UseStartup<Startup>()
				.UseUrls("http://0.0.0.0:5000")
				.Build();

			host.Run();
        }
    }
}
