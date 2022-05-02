using CombatReports.Data.Models;
using CombatReports.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CombatReports.Data.Repositories.ImplementedRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MilitaryOrdersContext context)
               : base(context)
        { }

        public User GetUserByCredentials(string userName, byte[] password)
        {
            return Entities.Include(x => x.UserRoles).FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }
    }
}