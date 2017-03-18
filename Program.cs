using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http;

namespace PostgresSampleApp
{
    public class Program
    {
        static HttpClient _hc;
        
        static async Task MaintainAsync()
        {
            while (true)
            {
                await Task.Delay(TimeSpan.FromMinutes(25));
                await _hc.GetAsync("https://fepora.herokuapp.com/home/incr");
            }
        }
        
        public static void Main(string[] args)
        {
            var res = MaintainAsync();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(string.Format("{0}", args[0]))
                .Build();

            host.Run();
        }
    }
}
