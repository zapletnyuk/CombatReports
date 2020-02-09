using CombatReports.BLL.Services.Interfaces;
using CombatReports.DAL.Models;
using CombatReports.DAL.UnitOfWork;
using System.Collections.Generic;

namespace CombatReports.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork database;
        public UserService(IUnitOfWork database)
        {
            this.database = database;
        }

        public List<Users> GetUsers()
        {
            return database.UserRepository.GetAll();
        }
    }
}
