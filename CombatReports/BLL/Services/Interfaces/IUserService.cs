using CombatReports.DAL.Models;
using System.Collections.Generic;

namespace CombatReports.BLL.Services.Interfaces
{
    public interface IUserService
    {
        List<Users> GetUsers();
    }
}
