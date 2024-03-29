﻿using CombatReports.Data.Models;
using CombatReports.Helpers;
using System.Collections.Generic;

namespace CombatReports.Business.Services.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrders(UserProfile userProfile);
        Order AddOrder(string path, int userId, int formId);
    }
}