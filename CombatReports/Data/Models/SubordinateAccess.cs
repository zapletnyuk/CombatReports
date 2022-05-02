using CombatReports.Data.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CombatReports.Data.Models
{
    public class SubordinateAccess : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ChiefId { get; set; }
        public User User { get; set; }
        public User Chief { get; set; }
    }
}