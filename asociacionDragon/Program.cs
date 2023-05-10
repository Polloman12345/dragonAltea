using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.Extensions.Configuration;
using asociacionDragon.infrastructure.repository;
using asociacionDragon.application;
using asociacionDragon.forms;

namespace asociacionDragon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configurar servicios
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Crear proveedor de servicios
            var serviceProvider = services.BuildServiceProvider();

            // Obtener formulario principal desde el proveedor de servicios
            var form = serviceProvider.GetRequiredService<Menu>();

            Application.Run(form);
        }

        private static void ConfigureServices(IServiceCollection services)
        {

            //de primeras lo pongo todo transient
            services.AddTransient<IGameRepository>(o => new JsonGameRepository("C:\\temp\\asociacionDragonData.json"));
            services.AddTransient<IMemberRepository, JsonMemberRepository>();
            services.AddTransient<GameService>();
            services.AddTransient<MemberService>();

            services.AddTransient<Menu>();
            services.AddTransient<GameList>();
            services.AddTransient<AddGameForm>();
        }

    }
}