using CombatReports.DAL.Models;
using System.Collections.Generic;

namespace CombatReports.BLL.Services.Interfaces
{
    interface IHashService
    {
        List<Hash> GetHash();
    }
}
