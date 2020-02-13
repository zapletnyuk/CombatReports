using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderRepository OrderRepository { get; }
        IHashRepository HashRepository { get; }
        void Save();
    }
}
