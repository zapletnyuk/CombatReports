using CombatReports.BLL.Services.Interfaces;
using CombatReports.DAL.Models;
using CombatReports.DAL.UnitOfWork;
using CombatReports.Helpers;

namespace CombatReports.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork database;
        public OrderService(IUnitOfWork database)
        {
            this.database = database;
        }
        public Orders AddOrder(string path)
        {
            var (shortFileName, fileData) = GeneratedFileData.GetFileInfo(path);

            Orders order = new Orders { FileName = shortFileName, FileData = fileData };
            database.OrderRepository.Add(order);
            database.Save();
            return order;
        }
    }
}
