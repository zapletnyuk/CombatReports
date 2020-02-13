using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrdersDbContext context;

        public IOrderRepository OrderRepository { get; }
        public IHashRepository HashRepository { get; }

        public UnitOfWork(OrdersDbContext context, IOrderRepository orderRepository, IHashRepository hashRepository)
        {
            this.context = context;
            OrderRepository = orderRepository;
            HashRepository = hashRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
