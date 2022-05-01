using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MilitaryOrdersContext context;

        public IOrderRepository OrderRepository { get; }
        public IHashRepository HashRepository { get; }

        public UnitOfWork(MilitaryOrdersContext context, IOrderRepository orderRepository, IHashRepository hashRepository)
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