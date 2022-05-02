using CombatReports.Business.Services.Interfaces;
using CombatReports.Data.Models;
using CombatReports.Data.UnitOfWork;
using CombatReports.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace CombatReports.Business.Services
{
    public class FormAccessService : IFormAccessService
    {
        private readonly IUnitOfWork database;

        public FormAccessService(IUnitOfWork database)
        {
            this.database = database;
        }

        public List<FormAccess> GetFormAccesses(UserProfile userProfile)
        {
            return database.FormAccessRepository.GetAll().Where(x => x.UserId == userProfile.UserId || userProfile.HasFullAccess).ToList();
        }
    }
}