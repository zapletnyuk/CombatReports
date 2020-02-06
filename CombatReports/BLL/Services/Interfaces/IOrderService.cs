using CombatReports.DAL.Models;
using System.Collections.Generic;

namespace CombatReports.BLL.Services.Interfaces
{
    public interface IOrderService
    {
        List<Orders> GetOrders();
        Orders AddOrder(string path);
    }
}
