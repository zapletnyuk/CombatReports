using CombatReports.Data.Models;
using System.Collections.Generic;

namespace CombatReports.Business.Services.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        Order AddOrder(string path);
    }
}