using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

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
