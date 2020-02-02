using CombatReports.DAL.Repositories.InterfacesRepositories;
using CombatReports.DAL.Models;

namespace CombatReports.DAL.Repositories.ImplementedRepositories
{
    public class OrderRepository : BaseRepository<Orders>, IOrderRepository
    {
        public OrderRepository(OrdersDbContext context)
               : base(context)
        {
        }
    }
}
