using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;

namespace CombatReports.Data.Repositories.ImplementedRepositories
{
    public class FormAccessRepository : BaseRepository<FormAccess>, IFormAccessRepository
    {
        public FormAccessRepository(MilitaryOrdersContext context)
               : base(context)
        { }
    }
}