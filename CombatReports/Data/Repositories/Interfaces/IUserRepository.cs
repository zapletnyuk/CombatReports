using CombatReports.Data.Models;

namespace CombatReports.Data.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User> 
    {
        public User GetUserByCredentials(string userName, byte[] password);
    }
}