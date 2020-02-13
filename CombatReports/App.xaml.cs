﻿using CombatReports.BLL.Services;
using CombatReports.BLL.Services.Interfaces;
using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.ImplementedRepositories;
using CombatReports.DAL.Repositories.InterfacesRepositories;
using CombatReports.DAL.UnitOfWork;
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

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OrdersDbContext>
                (options => options.UseSqlServer(
                    Configuration.GetConnectionString("SqlConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IHashService, HashService>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IHashRepository, HashRepository>();

            services.AddScoped(typeof(MainWindow));
        }
    }
}
