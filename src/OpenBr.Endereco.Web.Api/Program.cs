using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace OpenBr.Endereco.Web.Api
{

    /// <summary>
    /// Objeto de kick-off da aplica��o
    /// </summary>
    public class Program
    {

        /// <summary>
        /// M�todo principal de kick-off
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Construtor do ambiente
        /// </summary>
        /// <param name="args">Lista de argumentos</param>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
