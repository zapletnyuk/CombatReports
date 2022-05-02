using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Data.UnitOfWork;
using CombatReports.Helpers;
using System.Collections.Generic;
using System.Linq;

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

        public List<Order> GetOrders(UserProfile userProfile)
        {
            var orders = database.OrderRepository.GetAll();
            var formAccesses = database.FormAccessRepository.GetAll().Where(x => x.UserId == userProfile.UserId).Select(x => x.FormId).ToList();
            var subordinateAccesses = database.SubordinateAccessRepository.GetAll().Where(x => x.UserId == userProfile.UserId).Select(x => x.ChiefId).ToList();

            return orders.Where(x => (formAccesses.Contains(x.FormId) && subordinateAccesses.Contains(x.UserId)) || userProfile.HasFullAccess || x.UserId == userProfile.UserId).ToList();
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