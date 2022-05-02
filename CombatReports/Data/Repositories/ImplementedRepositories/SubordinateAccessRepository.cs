using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.Repositories.ImplementedRepositories
{
    public class SubordinateAccessRepository : BaseRepository<SubordinateAccess>, ISubordinateAccessRepository
    {
        public SubordinateAccessRepository(MilitaryOrdersContext context)
               : base(context)
        { }
    }
}