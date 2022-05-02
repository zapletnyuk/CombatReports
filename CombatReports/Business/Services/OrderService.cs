using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Data.UnitOfWork;
using CombatReports.Helpers;
using System.Collections.Generic;

namespace CombatReports.Business.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork database;
        private readonly IHashService hashService;
        public OrderService(IUnitOfWork database, IHashService hashService)
        {
            this.database = database;
            this.hashService = hashService;
        }

        public List<Order> GetOrders()
        {
            return database.OrderRepository.GetAll();
        }

        public Order AddOrder(string path, int userId, int formId)
        {
            var hash = hashService.GetHash();
            var (shortFileName, fileData) = GeneratedFileData.GetFileInfo(path, hash);

            Order order = new Order { FileName = shortFileName, FileData = fileData, UserId = userId, FormId = formId };
            database.OrderRepository.Add(order);
            database.Save();
            return order;
        }
    }
}