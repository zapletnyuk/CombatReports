using CombatReports.Business.Services;
using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Data.Repositories.ImplementedRepositories;
using CombatReports.Data.Repositories.Interfaces;
using CombatReports.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;

namespace CombatReports
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        public App()
        {
            ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var authenticationWindow = ServiceProvider.GetRequiredService<AuthenticationWindow>();
            authenticationWindow.ShowDialog();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MilitaryOrdersContext>
                (options => options.UseSqlServer(
                    Configuration.GetConnectionString("SqlConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IHashRepository, HashRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped(typeof(MainWindow));
            services.AddScoped(typeof(AuthenticationWindow));
        }
    }
}