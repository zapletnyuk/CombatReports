using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrdersDbContext context;

        public IOrderRepository OrderRepository { get; }
        public IHashRepository HashRepository { get; }
        public IUserRepository UserRepository { get; }

        public UnitOfWork(OrdersDbContext context, IOrderRepository orderRepository, IHashRepository hashRepository, IUserRepository userRepository)
        {
            this.context = context;
            OrderRepository = orderRepository;
            HashRepository = hashRepository;
            UserRepository = userRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
