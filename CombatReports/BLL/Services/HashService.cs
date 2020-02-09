using CombatReports.BLL.Services.Interfaces;
using CombatReports.DAL.Models;
using CombatReports.DAL.UnitOfWork;
using System.Linq;

namespace CombatReports.BLL.Services
{
    public class HashService : IHashService
    {
        private readonly IUnitOfWork database;
        public HashService(IUnitOfWork database)
        {
            this.database = database;
        }

        public Hash GetHash()
        {
            return database.HashRepository.GetAll().FirstOrDefault();
        }
    }
}
