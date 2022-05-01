using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.Repositories.ImplementedRepositories
{
    public class HashRepository : BaseRepository<Hash>, IHashRepository
    {
        public HashRepository(MilitaryOrdersContext context)
               : base(context)
        {
        }
    }
}