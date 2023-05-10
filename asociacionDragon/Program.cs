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
            ApplicationConfiguration.Initialize();

            GameRepository repository = new JsonGameRepository("C:\\workspace\\asociacionDragon\\data\\asociacionDragonData.json");
            GameService gameService = new(repository);
            Application.Run(new Menu());
        }

    }
}