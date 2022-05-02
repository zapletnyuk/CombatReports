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
        public ISubordinateAccessRepository SubordinateAccessRepository { get; }
        public IFormAccessRepository FormAccessRepository { get; }

        public UnitOfWork(MilitaryOrdersContext context, IOrderRepository orderRepository, 
            IHashRepository hashRepository, 
            IUserRepository userRepository,
            ISubordinateAccessRepository subordinateAccessRepository,
            IFormAccessRepository formAccessRepository)
        {
            this.context = context;
            OrderRepository = orderRepository;
            HashRepository = hashRepository;
            UserRepository = userRepository;
            SubordinateAccessRepository = subordinateAccessRepository;
            FormAccessRepository = formAccessRepository;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}