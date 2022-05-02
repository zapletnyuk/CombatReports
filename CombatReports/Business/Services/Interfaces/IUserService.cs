using CombatReports.Data.Models;
using CombatReports.Helpers;

namespace CombatReports.Business.Services.Interfaces
{
    public interface IUserService
    {
        UserProfile GetUserByCredentials(string userName, string password);
    }
}