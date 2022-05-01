using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Data.UnitOfWork;
using System.Linq;

namespace CombatReports.Business.Services
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