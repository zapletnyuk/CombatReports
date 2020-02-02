using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrdersDbContext context;

        public IOrderRepository OrderRepository { get; }

        public UnitOfWork(OrdersDbContext context, IOrderRepository orderRepository)
        {
            this.context = context;
            OrderRepository = orderRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
