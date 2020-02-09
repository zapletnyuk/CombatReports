using CombatReports.DAL.Models;
using CombatReports.DAL.Repositories.InterfacesRepositories;

namespace CombatReports.DAL.Repositories.ImplementedRepositories
{
    class UserRepository : BaseRepository<Users>, IUserRepository
    {
        public UserRepository(OrdersDbContext context)
               : base(context)
        {
        }
    }
}
