using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }
        IHashRepository HashRepository { get; }
        IUserRepository UserRepository { get; }
        void Save();
    }
}
