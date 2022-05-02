using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }
        IHashRepository HashRepository { get; }
        IUserRepository UserRepository { get; }
        void Save();
    }
}