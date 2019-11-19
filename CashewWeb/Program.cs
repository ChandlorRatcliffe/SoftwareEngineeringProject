using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CashewWeb
{
    /// <summary>
    /// This is the Driver for the Web Application, Creator: Nicholas Jones
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Command Line Driver Caller Method
        /// </summary>
        /// <param name="args">Command line argument Passing</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Specifies that the Driver should use the Startup.cs File for Settings
        /// </summary>
        /// <param name="args">command line argument passing</param>
        /// <returns>IHostBuilder</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
