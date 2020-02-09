using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.Repositories.ImplementedRepositories
{
    public class HashRepository : BaseRepository<Hash>, IHashRepository
    {
        public HashRepository(OrdersDbContext context)
               : base(context)
        {
        }
    }
}
