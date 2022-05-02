using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MilitaryOrdersContext context;

        public IOrderRepository OrderRepository { get; }
        public IHashRepository HashRepository { get; }
        public IUserRepository UserRepository { get; }

        public UnitOfWork(MilitaryOrdersContext context, IOrderRepository orderRepository, IHashRepository hashRepository, IUserRepository userRepository)
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