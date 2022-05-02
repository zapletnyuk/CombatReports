using CombatReports.Data.Models;
using CombatReports.Helpers;
using System.Collections.Generic;

namespace CombatReports.Business.Services.Interfaces
{
    public interface IFormAccessService
    {
        List<FormAccess> GetFormAccesses(UserProfile userProfile);
    }
}