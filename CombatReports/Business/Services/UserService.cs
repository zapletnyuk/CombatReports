using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.UnitOfWork;
using CombatReports.Helpers;
using System.Linq;
using Constant = CombatReports.Constants.Constants;

namespace CombatReports.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork database;
        public UserService(IUnitOfWork database)
        {
            this.database = database;
        }

        public UserProfile GetUserByCredentials(string userName, string password)
        {
            var saltedPassword = string.Concat(userName, password);
            var hashedSaltedPassword = SHA256Hash.ComputeHash(saltedPassword);

            var user = database.UserRepository.GetUserByCredentials(userName, hashedSaltedPassword);

            if (user == null)
            {
                return null;
            }

            return new UserProfile { UserId = user.Id, HasFullAccess = user.UserRoles.Where(x => x.RoleId == Constant.Admin).Any() };
        }
    }
}