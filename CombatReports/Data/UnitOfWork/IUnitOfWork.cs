using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }
        IHashRepository HashRepository { get; }
        IUserRepository UserRepository { get; }
        ISubordinateAccessRepository SubordinateAccessRepository { get; }
        IFormAccessRepository FormAccessRepository { get; }
        void Save();
    }
}