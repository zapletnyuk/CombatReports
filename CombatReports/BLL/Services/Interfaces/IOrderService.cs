using CombatReports.DAL.Models;

namespace CombatReports.BLL.Services.Interfaces
{
    public interface IOrderService
    {
        Orders AddOrder(string path);
    }
}
